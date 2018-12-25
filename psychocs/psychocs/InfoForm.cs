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
        public string Age { get; set; }
        public string SubjectId { get; set; }
        public DateTime Date { get; set; }

        private GameForm _GameForm { get; set; }

        public InfoForm()
        {
            InitializeComponent();

            // Set the _DateTime to the time the form opens
            Date = System.DateTime.Now;
            DateTime = Date.ToString("MM/dd/yyyy hh:mm tt");
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
                    Date = Convert.ToDateTime(uxDateTextbox.Text);
                    Age = uxAgeTextbox.Text;

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
            if (!IsCorrectString(uxAgeTextbox.Text) || HasComma(uxAgeTextbox.Text))
            {
                uxAgeWarning.Text = "*Age is Required";
                if (HasComma(uxAgeTextbox.Text))
                {
                    uxAgeWarning.Text += " Without a Comma";
                }
                uxAgeWarning.Visible = true;
                ans = false;
            }
            if (!IsCorrectString(uxSexTextbox.Text) || HasComma(uxSexTextbox.Text))
            {
                uxSexWarning.Text = "*Sex is Required";
                if (HasComma(uxSexTextbox.Text))
                {
                    uxSexWarning.Text += " Without a Comma";
                }
                uxSexWarning.Visible = true;
                ans = false;
            }
            if (!IsCorrectString(uxSubjectIdTextbox.Text) || HasComma(uxSubjectIdTextbox.Text))
            {
                uxSubIdWarning.Text = "*Subject Id is Required";
                if (HasComma(uxSubjectIdTextbox.Text))
                {
                    uxSubIdWarning.Text += " Without a Comma";
                }
                uxSubIdWarning.Visible = true;
                ans = false;
            }
            if (!IsCorrectString(uxDateTextbox.Text) || !IsCorrectDateTimeFormat(uxDateTextbox.Text) || HasComma(uxDateTextbox.Text))
            {
                uxDateWarning.Text = "*Date is Required";
                if (HasComma(uxDateTextbox.Text))
                {
                    uxDateWarning.Text += " Without a Comma";
                }
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

        private bool HasComma(string str)
        {
            return str.Contains(',');
        }

        private bool IsCorrectDateTimeFormat(string str)
        {
            try
            {
                Convert.ToDateTime(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Does stuff when the Game Form Closes
        /// </summary>
        public void GameFormClosed()
        {
            // Set the _DateTime to the time the form opens
            Date = System.DateTime.Now;
            DateTime = Date.ToString("MM/dd/yyyy hh:mm tt");
            uxDateTextbox.Text = DateTime;
        }
    }
}
