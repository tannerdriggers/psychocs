using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psychocs
{
    public partial class GameForm : Form
    {
        /// <summary>
        /// InfoForm Object that created the GameForm
        /// </summary>
        private InfoForm _infoForm { get; }

        private string dataFilePath;

        /// <summary>
        /// Whether or not the Game has actually been started or not
        /// </summary>
        private bool _started;
        private bool keyClicked;
        private bool _firstTime;
        private int randomNumber;
        private bool correctResponse;
        private string elapsedTime;

        private System.Windows.Forms.Timer everyCycleTimer;
        private System.Windows.Forms.Timer numberCycleTimer;
        private System.Windows.Forms.Timer programTimer;

        private Stopwatch keyTime = new Stopwatch();

        public GameForm(InfoForm infoForm)
        {
            InitializeComponent();
            _infoForm = infoForm;

            everyCycleTimer = new System.Windows.Forms.Timer();
            numberCycleTimer = new System.Windows.Forms.Timer();
            programTimer = new System.Windows.Forms.Timer();

            numberCycleTimer.Tick += new EventHandler(NumberTime);
            numberCycleTimer.Interval = 250;

            everyCycleTimer.Tick += new EventHandler(CircleMaskTime);
            everyCycleTimer.Interval = 900 + 250;

            programTimer.Tick += new EventHandler(End);
            programTimer.Interval = 1000 * 60 * 5;
        }

        /// <summary>
        /// Initializes the Game Form
        /// </summary>
        private void Init()
        {
            SetDefaults();

            // Puts up the SART.txt file on the first screen
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(GetRootDirectory(), "Stimuli/SART.txt")))
                {
                    string text = sr.ReadToEnd();
                    DisplayText(text);
                }
            }
            catch (Exception)
            {
                DisplayText("Could not read the Welcome file. Please contact an administrator.");
            }

            // Creates the data file for the user
            try
            {
                // Creating the File Name
                var dataFileName = _infoForm.SubjectId + "_" + _infoForm.Date.ToString("yyyy-MM-dd_hh-mm");
                foreach (var c in Path.GetInvalidFileNameChars())
                {
                    if (c == '/' || c == ':')
                    {
                        dataFileName = dataFileName.Replace(c, '-');
                    }

                    dataFileName = dataFileName.Replace(c, '_');
                }
                dataFileName = dataFileName.Replace(' ', '_');

                // Create Data Folder
                var dataDir = Path.Combine(GetRootDirectory(), "psychocs_Data");
                Directory.CreateDirectory(dataDir);

                // Creating the File in the Data folder
                dataFilePath = Path.Combine(dataDir, dataFileName);

                dataFilePath = RenameFile(dataFilePath) + ".csv";

                using (StreamWriter sw = new StreamWriter(dataFilePath, false))
                {
                    sw.WriteLine("Subject_Id,Age,Sex,Reaction_Number,Reaction_Time,Correct_Response");
                }
            }
            catch (Exception)
            {
                DisplayText("Could not create the data file. Please contact an administrator.");
            }

            // Loads the Circle Mask image
            try
            {
                uxCircleMask.Visible = false;

                // Loading the Image
                uxCircleMask.Image = Image.FromFile(Path.Combine(Path.Combine(GetRootDirectory(), "Stimuli"), "circleMask2.png"));

                // Resizing
                uxCircleMask.Width = Width / 8;
                uxCircleMask.Height = Width / 8;

                // Centering the location on screen
                int width = Width / 2 - uxCircleMask.Width / 2;
                int height = Height / 2 - uxCircleMask.Height / 2;
                uxCircleMask.Location = new Point(width, height);
            }
            catch (Exception)
            {
                DisplayText("Cannot load the Circle Mask. Please contact an administrator.");
            }

            // Loads the Number for the Circle Mask
            try
            {
                uxNumberLabel.Visible = false;

                // Resizing
                uxNumberLabel.Width = Width / 8;
                uxNumberLabel.Height = Width / 8;

                // Centering the location on screen
                int width = Width / 2 - uxNumberLabel.Width / 2;
                int height = Height / 2 - uxNumberLabel.Height / 2;
                uxNumberLabel.Location = new Point(width, height);
            }
            catch (Exception)
            {
                DisplayText("There is something wrong with the Random Number Label. Please contact an administrator.");
            }
        }

        private string RenameFile(string fileName)
        {
            int count = 1;

            string fileNameOnly = Path.GetFileNameWithoutExtension(fileName);
            string extension = ".csv";
            string path = Path.GetDirectoryName(fileName);
            string newFullPath = fileName;

            while (File.Exists(newFullPath + extension))
            {
                string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                newFullPath = Path.Combine(path, tempFileName);
            }

            return newFullPath;
        }

        private void DisplayText(string text)
        {
            uxWelcomeLabel.Visible = true;
            uxWelcomeLabel.Text = text;

            // Centers the Text to the window
            int width = Width / 2 - uxWelcomeLabel.Width / 2;
            int height = Height / 2 - uxWelcomeLabel.Height / 2;
            uxWelcomeLabel.Location = new Point(width, height);
        }

        /// <summary>
        /// Gets the Root Directory of the Application
        /// </summary>
        /// <returns>Local Path to the Root Directory</returns>
        private string GetRootDirectory()
        {
            return new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)").Match(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).ToString();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                _started = false;
                Close();
                return true;
            }

            if (!_started)
            {
                Start();
            }
            else
            {
                if (ModifierKeys == Keys.None && keyData == Keys.Space)
                {
                    if (randomNumber != 3)
                    {
                        correctResponse = true;
                    }
                    keyClicked = true;

                    TimeSpan ts = keyTime.Elapsed;
                    elapsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10);
                }
            }

            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// Runs the Init every time the GameForm loads
        /// </summary>
        private void GameForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void GameForm_Closed(object sender, EventArgs e)
        {
            SetDefaults();
            _infoForm.GameFormClosed();
            Dispose();
        }

        private void SetDefaults()
        {
            _firstTime = true;
            _started = false;
            keyClicked = false;
            randomNumber = new Random().Next(0, 10);
            correctResponse = false;
            elapsedTime = "00.00";

            if (everyCycleTimer != null)
            {
                everyCycleTimer.Stop();
                numberCycleTimer.Stop();
                programTimer.Stop();
                keyTime.Reset();
            }

            keyTime = new Stopwatch();
        }

        /// <summary>
        /// Starts the actual game
        /// </summary>
        private void Start()
        {
            _started = true;
            correctResponse = false;
            uxCircleMask.BringToFront();
            uxWelcomeLabel.Visible = false;
            uxCircleMask.Visible = true;
            uxNumberLabel.Visible = true;
            
            everyCycleTimer.Start();
            programTimer.Start();
        }

        private void CircleMaskTime(object sender, EventArgs e)
        {
            if (!_firstTime)
            {
                // The end of the cycle
                if (!keyClicked)
                {
                    if (randomNumber == 3)
                    {
                        correctResponse = true;
                    }
                    else
                    {
                        correctResponse = false;
                    }
                    elapsedTime = "N/A";
                }
                keyTime.Stop();
                keyTime.Reset();
                WriteToFile(elapsedTime);
            }
            _firstTime = false;

            // The start of the cycle
            randomNumber = new Random().Next(0, 10);
            uxNumberLabel.Text = randomNumber.ToString();
            keyTime.Start();
            numberCycleTimer.Start();
            correctResponse = false;
            keyClicked = false;
            uxCircleMask.Visible = false;
        }

        private void NumberTime(object sender, EventArgs e)
        {
            uxCircleMask.Visible = true;
            numberCycleTimer.Stop();
        }

        private void End(object sender, EventArgs e)
        {
            everyCycleTimer.Stop();
            uxCircleMask.Visible = false;
            uxNumberLabel.Visible = false;
            DisplayText("End of the Test! Press Escape to finish.");
        }

        private void WriteToFile(string reactionTime)
        {
            using (StreamWriter sw = new StreamWriter(dataFilePath, true))
            {
                sw.WriteLine(_infoForm.SubjectId + "," + _infoForm.Age + "," + _infoForm.Sex + "," 
                    + randomNumber + "," + reactionTime + "," + correctResponse);
            }
        }
    }
}
