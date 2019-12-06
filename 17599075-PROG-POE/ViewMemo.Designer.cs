namespace _17599075_PROG_POE
{
    partial class ViewMemo
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
            this.QuestionNumLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SolAansLabel = new System.Windows.Forms.Label();
            this.SolBansLabel = new System.Windows.Forms.Label();
            this.SolCansLabel = new System.Windows.Forms.Label();
            this.correctAnsLabel = new System.Windows.Forms.Label();
            this.backButton1 = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.navLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionNumLabel
            // 
            this.QuestionNumLabel.AutoSize = true;
            this.QuestionNumLabel.Location = new System.Drawing.Point(251, 43);
            this.QuestionNumLabel.Name = "QuestionNumLabel";
            this.QuestionNumLabel.Size = new System.Drawing.Size(192, 32);
            this.QuestionNumLabel.TabIndex = 0;
            this.QuestionNumLabel.Text = "Question num";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(77, 132);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(161, 32);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "QUESTION";
            // 
            // SolAansLabel
            // 
            this.SolAansLabel.AutoSize = true;
            this.SolAansLabel.Location = new System.Drawing.Point(77, 219);
            this.SolAansLabel.Name = "SolAansLabel";
            this.SolAansLabel.Size = new System.Drawing.Size(98, 32);
            this.SolAansLabel.TabIndex = 2;
            this.SolAansLabel.Text = "SOL A";
            // 
            // SolBansLabel
            // 
            this.SolBansLabel.AutoSize = true;
            this.SolBansLabel.Location = new System.Drawing.Point(77, 307);
            this.SolBansLabel.Name = "SolBansLabel";
            this.SolBansLabel.Size = new System.Drawing.Size(98, 32);
            this.SolBansLabel.TabIndex = 3;
            this.SolBansLabel.Text = "SOL B";
            // 
            // SolCansLabel
            // 
            this.SolCansLabel.AutoSize = true;
            this.SolCansLabel.Location = new System.Drawing.Point(77, 392);
            this.SolCansLabel.Name = "SolCansLabel";
            this.SolCansLabel.Size = new System.Drawing.Size(99, 32);
            this.SolCansLabel.TabIndex = 4;
            this.SolCansLabel.Text = "SOL C";
            // 
            // correctAnsLabel
            // 
            this.correctAnsLabel.AutoSize = true;
            this.correctAnsLabel.Location = new System.Drawing.Point(77, 499);
            this.correctAnsLabel.Name = "correctAnsLabel";
            this.correctAnsLabel.Size = new System.Drawing.Size(160, 32);
            this.correctAnsLabel.TabIndex = 6;
            this.correctAnsLabel.Text = "Correct ans";
            // 
            // backButton1
            // 
            this.backButton1.Location = new System.Drawing.Point(83, 706);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(143, 70);
            this.backButton1.TabIndex = 7;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(447, 706);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(143, 70);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // navLabel
            // 
            this.navLabel.AutoSize = true;
            this.navLabel.Location = new System.Drawing.Point(316, 721);
            this.navLabel.Name = "navLabel";
            this.navLabel.Size = new System.Drawing.Size(55, 32);
            this.navLabel.TabIndex = 9;
            this.navLabel.Text = "1/1";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 70);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(447, 706);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(143, 70);
            this.finishButton.TabIndex = 11;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Visible = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // ViewMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(738, 812);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.navLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.correctAnsLabel);
            this.Controls.Add(this.SolCansLabel);
            this.Controls.Add(this.SolBansLabel);
            this.Controls.Add(this.SolAansLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.QuestionNumLabel);
            this.Name = "ViewMemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMemo";
            this.Load += new System.EventHandler(this.ViewMemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionNumLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label SolAansLabel;
        private System.Windows.Forms.Label SolBansLabel;
        private System.Windows.Forms.Label SolCansLabel;
        private System.Windows.Forms.Label correctAnsLabel;
        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label navLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button finishButton;
    }
}