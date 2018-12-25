namespace psychocs
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxAgeLabel = new System.Windows.Forms.Label();
            this.uxSexLabel = new System.Windows.Forms.Label();
            this.uxSubjectIdLabel = new System.Windows.Forms.Label();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxAgeTextbox = new System.Windows.Forms.TextBox();
            this.uxSexTextbox = new System.Windows.Forms.ComboBox();
            this.uxSubjectIdTextbox = new System.Windows.Forms.TextBox();
            this.uxDateTextbox = new System.Windows.Forms.TextBox();
            this.uxStartButton = new System.Windows.Forms.Button();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxAgeWarning = new System.Windows.Forms.Label();
            this.uxSexWarning = new System.Windows.Forms.Label();
            this.uxSubIdWarning = new System.Windows.Forms.Label();
            this.uxDateWarning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAgeLabel
            // 
            this.uxAgeLabel.AutoSize = true;
            this.uxAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAgeLabel.Location = new System.Drawing.Point(69, 21);
            this.uxAgeLabel.Name = "uxAgeLabel";
            this.uxAgeLabel.Size = new System.Drawing.Size(56, 25);
            this.uxAgeLabel.TabIndex = 0;
            this.uxAgeLabel.Text = "Age:";
            // 
            // uxSexLabel
            // 
            this.uxSexLabel.AutoSize = true;
            this.uxSexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSexLabel.Location = new System.Drawing.Point(70, 71);
            this.uxSexLabel.Name = "uxSexLabel";
            this.uxSexLabel.Size = new System.Drawing.Size(55, 25);
            this.uxSexLabel.TabIndex = 2;
            this.uxSexLabel.Text = "Sex:";
            // 
            // uxSubjectIdLabel
            // 
            this.uxSubjectIdLabel.AutoSize = true;
            this.uxSubjectIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubjectIdLabel.Location = new System.Drawing.Point(12, 123);
            this.uxSubjectIdLabel.Name = "uxSubjectIdLabel";
            this.uxSubjectIdLabel.Size = new System.Drawing.Size(113, 25);
            this.uxSubjectIdLabel.TabIndex = 3;
            this.uxSubjectIdLabel.Text = "Subject Id:";
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateLabel.Location = new System.Drawing.Point(62, 172);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(63, 25);
            this.uxDateLabel.TabIndex = 4;
            this.uxDateLabel.Text = "Date:";
            // 
            // uxAgeTextbox
            // 
            this.uxAgeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAgeTextbox.Location = new System.Drawing.Point(131, 18);
            this.uxAgeTextbox.Name = "uxAgeTextbox";
            this.uxAgeTextbox.Size = new System.Drawing.Size(141, 31);
            this.uxAgeTextbox.TabIndex = 5;
            this.uxAgeTextbox.Text = "21";
            // 
            // uxSexTextbox
            // 
            this.uxSexTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSexTextbox.FormattingEnabled = true;
            this.uxSexTextbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.uxSexTextbox.Location = new System.Drawing.Point(131, 68);
            this.uxSexTextbox.Name = "uxSexTextbox";
            this.uxSexTextbox.Size = new System.Drawing.Size(141, 33);
            this.uxSexTextbox.TabIndex = 6;
            this.uxSexTextbox.Text = "Male";
            // 
            // uxSubjectIdTextbox
            // 
            this.uxSubjectIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubjectIdTextbox.Location = new System.Drawing.Point(131, 120);
            this.uxSubjectIdTextbox.Name = "uxSubjectIdTextbox";
            this.uxSubjectIdTextbox.Size = new System.Drawing.Size(141, 31);
            this.uxSubjectIdTextbox.TabIndex = 7;
            this.uxSubjectIdTextbox.Text = "13";
            // 
            // uxDateTextbox
            // 
            this.uxDateTextbox.AllowDrop = true;
            this.uxDateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateTextbox.Location = new System.Drawing.Point(131, 170);
            this.uxDateTextbox.Multiline = true;
            this.uxDateTextbox.Name = "uxDateTextbox";
            this.uxDateTextbox.Size = new System.Drawing.Size(141, 64);
            this.uxDateTextbox.TabIndex = 8;
            // 
            // uxStartButton
            // 
            this.uxStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartButton.Location = new System.Drawing.Point(131, 319);
            this.uxStartButton.Name = "uxStartButton";
            this.uxStartButton.Size = new System.Drawing.Size(141, 42);
            this.uxStartButton.TabIndex = 9;
            this.uxStartButton.Text = "Start";
            this.uxStartButton.UseVisualStyleBackColor = true;
            this.uxStartButton.Click += new System.EventHandler(this.uxStartButton_Click);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(12, 319);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(113, 42);
            this.uxCancelButton.TabIndex = 10;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxAgeWarning
            // 
            this.uxAgeWarning.AutoSize = true;
            this.uxAgeWarning.BackColor = System.Drawing.SystemColors.Control;
            this.uxAgeWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.uxAgeWarning.Location = new System.Drawing.Point(72, 52);
            this.uxAgeWarning.Name = "uxAgeWarning";
            this.uxAgeWarning.Size = new System.Drawing.Size(86, 13);
            this.uxAgeWarning.TabIndex = 11;
            this.uxAgeWarning.Text = "*Age is Required";
            this.uxAgeWarning.Visible = false;
            // 
            // uxSexWarning
            // 
            this.uxSexWarning.AutoSize = true;
            this.uxSexWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.uxSexWarning.Location = new System.Drawing.Point(71, 104);
            this.uxSexWarning.Name = "uxSexWarning";
            this.uxSexWarning.Size = new System.Drawing.Size(85, 13);
            this.uxSexWarning.TabIndex = 12;
            this.uxSexWarning.Text = "*Sex is Required";
            this.uxSexWarning.Visible = false;
            // 
            // uxSubIdWarning
            // 
            this.uxSubIdWarning.AutoSize = true;
            this.uxSubIdWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.uxSubIdWarning.Location = new System.Drawing.Point(71, 154);
            this.uxSubIdWarning.Name = "uxSubIdWarning";
            this.uxSubIdWarning.Size = new System.Drawing.Size(115, 13);
            this.uxSubIdWarning.TabIndex = 13;
            this.uxSubIdWarning.Text = "*Subject Id is Required";
            this.uxSubIdWarning.Visible = false;
            // 
            // uxDateWarning
            // 
            this.uxDateWarning.AutoSize = true;
            this.uxDateWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.uxDateWarning.Location = new System.Drawing.Point(71, 237);
            this.uxDateWarning.Name = "uxDateWarning";
            this.uxDateWarning.Size = new System.Drawing.Size(90, 13);
            this.uxDateWarning.TabIndex = 14;
            this.uxDateWarning.Text = "*Date is Required";
            this.uxDateWarning.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "(Month/Day/Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hour:Min AM/PM)";
            // 
            // InfoForm
            // 
            this.AcceptButton = this.uxStartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancelButton;
            this.ClientSize = new System.Drawing.Size(290, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDateWarning);
            this.Controls.Add(this.uxSubIdWarning);
            this.Controls.Add(this.uxSexWarning);
            this.Controls.Add(this.uxAgeWarning);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxStartButton);
            this.Controls.Add(this.uxDateTextbox);
            this.Controls.Add(this.uxSubjectIdTextbox);
            this.Controls.Add(this.uxSexTextbox);
            this.Controls.Add(this.uxAgeTextbox);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxSubjectIdLabel);
            this.Controls.Add(this.uxSexLabel);
            this.Controls.Add(this.uxAgeLabel);
            this.Name = "InfoForm";
            this.Text = "Sustained Attention";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxAgeLabel;
        private System.Windows.Forms.Label uxSexLabel;
        private System.Windows.Forms.Label uxSubjectIdLabel;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.TextBox uxAgeTextbox;
        private System.Windows.Forms.ComboBox uxSexTextbox;
        private System.Windows.Forms.TextBox uxSubjectIdTextbox;
        private System.Windows.Forms.TextBox uxDateTextbox;
        private System.Windows.Forms.Button uxStartButton;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Label uxAgeWarning;
        private System.Windows.Forms.Label uxSexWarning;
        private System.Windows.Forms.Label uxSubIdWarning;
        private System.Windows.Forms.Label uxDateWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

