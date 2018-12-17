using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        /// <summary>
        /// Whether or not the Game has actually been started or not
        /// </summary>
        private volatile bool _started = false;

        private volatile System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        /// <summary>
        /// Number of times the user will see a number
        /// </summary>
        public int numberOfTests { get; set; }

        public GameForm(InfoForm infoForm)
        {
            InitializeComponent();
            _infoForm = infoForm;
        }

        /// <summary>
        /// Initializes the Game Form
        /// </summary>
        private void Init()
        {
            // Puts up the SART.txt file on the first screen
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(GetRootDirectory(), "Stimuli/SART.txt")))
                {
                    string text = sr.ReadToEnd();
                    uxWelcomeLabel.Text = text;

                    // Centers the Text to the window
                    int width = Width / 2 - uxWelcomeLabel.Width / 2;
                    int height = Height / 2 - uxWelcomeLabel.Height / 2;
                    uxWelcomeLabel.Location = new Point(width, height);
                }
            }
            catch (Exception)
            {
                uxWelcomeLabel.Text = "Could not read the Welcome file. Contact an administrator.";
            }

            // Creates the data file for the user
            try
            {
                // Creating the File Name
                var dataFileName = _infoForm.SubjectId + "_" + _infoForm.DateTime + ".csv";
                foreach (var c in Path.GetInvalidFileNameChars())
                {
                    if (c == '/' || c == ':')
                    {
                        dataFileName = dataFileName.Replace(c, '-');
                    }

                    dataFileName = dataFileName.Replace(c, '_');
                }
                dataFileName = dataFileName.Replace(' ', '_');

                // Creating the File in the Data folder
                var dataFilePath = Path.Combine(Path.Combine(GetRootDirectory(), "Data"), dataFileName);
                try
                {
                    File.Create(dataFilePath);
                } catch (Exception) { }
            }
            catch (Exception)
            {
                uxWelcomeLabel.Text = "Could not create the data file. Contact an administrator.";
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
                uxWelcomeLabel.Text = "Cannot load the Circle Mask. Contact an administrator.";
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
                uxWelcomeLabel.Text = "There is something wrong with the Numbers. Contact an administrator.";
            }
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

            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// Runs the Init every time the GameForm loads
        /// </summary>
        private void GameForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        /// <summary>
        /// Starts the actual game
        /// </summary>
        private void Start()
        {
            _started = true;
            uxCircleMask.BringToFront();
            uxWelcomeLabel.Visible = false;
            uxCircleMask.Visible = true;
            uxNumberLabel.Visible = true;

            var timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(CircleMaskTime);
            timer1.Interval = 300;
            timer1.InitializeLifetimeService();
            timer1.Start();
        }

        private void CircleMaskTime(object sender, EventArgs e)
        {
            uxCircleMask.Visible = !uxCircleMask.Visible;
            
            if (uxCircleMask.Visible)
            {

            }
        }
    }
}
