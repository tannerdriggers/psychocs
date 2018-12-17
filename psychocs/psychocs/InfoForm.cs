using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psychocs
{
    public partial class InfoForm : Form
    {
        public string DateTime { get; set; }
        public string Sex { get; set; }
        public string SubjectId { get; set; }
        public string Date { get; set; }

        private GameForm _GameForm { get; set; }

        public InfoForm()
        {
            InitializeComponent();

            // Set the _DateTime to the time the form opens
            DateTime = System.DateTime.Now.ToString();
            uxDateTextbox.Text = DateTime;
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            if (_GameForm != null)
            {
                _GameForm.Close();
            }
            Close();
        }

        private void uxStartButton_Click(object sender, EventArgs e)
        {
            if (_GameForm == null || _GameForm.IsDisposed)
            {
                if (CheckRequired())
                {
                    Sex = uxSexTextbox.Text;
                    SubjectId = uxSubjectIdTextbox.Text;
                    DateTime = uxDateTextbox.Text;

                    _GameForm = new GameForm(this)
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        WindowState = FormWindowState.Maximized,
                        TopMost = true
                    };
                    _GameForm.Show();
                }
            }
        }

        private bool CheckRequired()
        {
            ClearWarnings();

            bool ans = true;

            // Checks the textboxs to see if something is in them and pops up a warning if not
            if (!IsCorrectString(uxAgeTextbox.Text))
            {
                uxAgeWarning.Visible = true;
                ans = false;
            }
            if (!IsCorrectString(uxSexTextbox.Text))
            {
                uxSexWarning.Visible = true;
                ans = false;
            }
            if (!IsCorrectString(uxSubjectIdTextbox.Text))
            {
                uxSubIdWarning.Visible = true;
                ans = false;
            }
            if (!IsCorrectString(uxDateTextbox.Text))
            {
                uxDateWarning.Visible = true;
                ans = false;
            }

            if (ans)
            {
                ClearWarnings();
            }

            return ans;
        }

        private void ClearWarnings()
        {
            uxAgeWarning.Visible = false;
            uxSexWarning.Visible = false;
            uxSubIdWarning.Visible = false;
            uxDateWarning.Visible = false;
        }

        private bool IsCorrectString(string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }
    }
}
