namespace psychocs
{
    partial class GameForm
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
            this.uxWelcomeLabel = new System.Windows.Forms.Label();
            this.uxCircleMask = new System.Windows.Forms.PictureBox();
            this.uxNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxCircleMask)).BeginInit();
            this.SuspendLayout();
            // 
            // uxWelcomeLabel
            // 
            this.uxWelcomeLabel.AutoSize = true;
            this.uxWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWelcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.uxWelcomeLabel.Location = new System.Drawing.Point(13, 13);
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            this.uxWelcomeLabel.Size = new System.Drawing.Size(86, 31);
            this.uxWelcomeLabel.TabIndex = 0;
            this.uxWelcomeLabel.Text = "label1";
            // 
            // uxCircleMask
            // 
            this.uxCircleMask.Location = new System.Drawing.Point(350, 180);
            this.uxCircleMask.Name = "uxCircleMask";
            this.uxCircleMask.Size = new System.Drawing.Size(85, 85);
            this.uxCircleMask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uxCircleMask.TabIndex = 1;
            this.uxCircleMask.TabStop = false;
            // 
            // uxNumberLabel
            // 
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.ForeColor = System.Drawing.Color.White;
            this.uxNumberLabel.Location = new System.Drawing.Point(213, 207);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(98, 108);
            this.uxNumberLabel.TabIndex = 2;
            this.uxNumberLabel.Text = "0";
            this.uxNumberLabel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxNumberLabel);
            this.Controls.Add(this.uxCircleMask);
            this.Controls.Add(this.uxWelcomeLabel);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.uxCircleMask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxWelcomeLabel;
        private System.Windows.Forms.PictureBox uxCircleMask;
        private System.Windows.Forms.Label uxNumberLabel;
    }
}