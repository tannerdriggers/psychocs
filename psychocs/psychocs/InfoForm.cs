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
            if (_GameForm == null)
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
}
