using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psychocs
{
    public partial class GameForm : Form
    {
        InfoForm _infoForm { get; }

        public GameForm(InfoForm infoForm)
        {
            InitializeComponent();
            _infoForm = infoForm;

            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)").Match(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).ToString(), "Stimuli/SART.txt")))
                {
                    string text = sr.ReadToEnd();
                    uxWelcomeLabel.Text = text;
                }
            }
            catch (Exception)
            {
                uxWelcomeLabel.Text = "Could not read the Welcome file. Contact an administrator.";
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public string GetApplicationPath()
        {
            var exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            return appPathMatcher.Match(exePath).Value;
        }
    }
}
