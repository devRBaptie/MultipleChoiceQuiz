namespace _17599075_PROG_POE
{
    partial class takeTest
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
            this.solARadio = new System.Windows.Forms.RadioButton();
            this.quesNumLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.solBRadio = new System.Windows.Forms.RadioButton();
            this.solCRadio = new System.Windows.Forms.RadioButton();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton2 = new System.Windows.Forms.Button();
            this.navLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // solARadio
            // 
            this.solARadio.AutoSize = true;
            this.solARadio.Location = new System.Drawing.Point(100, 305);
            this.solARadio.Name = "solARadio";
            this.solARadio.Size = new System.Drawing.Size(113, 36);
            this.solARadio.TabIndex = 1;
            this.solARadio.Text = "SolA";
            this.solARadio.UseVisualStyleBackColor = true;
            // 
            // quesNumLabel
            // 
            this.quesNumLabel.AutoSize = true;
            this.quesNumLabel.Location = new System.Drawing.Point(100, 58);
            this.quesNumLabel.Name = "quesNumLabel";
            this.quesNumLabel.Size = new System.Drawing.Size(192, 32);
            this.quesNumLabel.TabIndex = 2;
            this.quesNumLabel.Text = "Question num";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(100, 165);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(130, 32);
            this.QuestionLabel.TabIndex = 3;
            this.QuestionLabel.Text = "Question";
            // 
            // solBRadio
            // 
            this.solBRadio.AutoSize = true;
            this.solBRadio.Location = new System.Drawing.Point(100, 405);
            this.solBRadio.Name = "solBRadio";
            this.solBRadio.Size = new System.Drawing.Size(113, 36);
            this.solBRadio.TabIndex = 2;
            this.solBRadio.Text = "SolB";
            this.solBRadio.UseVisualStyleBackColor = true;
            // 
            // solCRadio
            // 
            this.solCRadio.AutoSize = true;
            this.solCRadio.Location = new System.Drawing.Point(100, 505);
            this.solCRadio.Name = "solCRadio";
            this.solCRadio.Size = new System.Drawing.Size(114, 36);
            this.solCRadio.TabIndex = 3;
            this.solCRadio.Text = "SolC";
            this.solCRadio.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(489, 637);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(135, 70);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(102, 637);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(135, 70);
            this.backButton2.TabIndex = 7;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // navLabel
            // 
            this.navLabel.AutoSize = true;
            this.navLabel.Location = new System.Drawing.Point(337, 657);
            this.navLabel.Name = "navLabel";
            this.navLabel.Size = new System.Drawing.Size(55, 32);
            this.navLabel.TabIndex = 8;
            this.navLabel.Text = "1/3";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(489, 637);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(135, 70);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // takeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 762);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.navLabel);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.solCRadio);
            this.Controls.Add(this.solBRadio);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.quesNumLabel);
            this.Controls.Add(this.solARadio);
            this.Name = "takeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "takeTest";
            this.Load += new System.EventHandler(this.takeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton solARadio;
        private System.Windows.Forms.Label quesNumLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton solBRadio;
        private System.Windows.Forms.RadioButton solCRadio;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Label navLabel;
        private System.Windows.Forms.Button submitButton;
    }
}