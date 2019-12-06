namespace _17599075_PROG_POE
{
    partial class LECTURERS
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
            this.backButton1 = new System.Windows.Forms.Button();
            this.testSetupButton = new System.Windows.Forms.Button();
            this.rubrikButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton1
            // 
            this.backButton1.BackColor = System.Drawing.Color.Silver;
            this.backButton1.CausesValidation = false;
            this.backButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton1.Location = new System.Drawing.Point(30, 30);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(135, 70);
            this.backButton1.TabIndex = 0;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = false;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            this.backButton1.MouseHover += new System.EventHandler(this.backHover);
            // 
            // testSetupButton
            // 
            this.testSetupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.testSetupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testSetupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testSetupButton.Location = new System.Drawing.Point(230, 300);
            this.testSetupButton.Name = "testSetupButton";
            this.testSetupButton.Size = new System.Drawing.Size(255, 105);
            this.testSetupButton.TabIndex = 1;
            this.testSetupButton.Text = "Set up new test";
            this.testSetupButton.UseVisualStyleBackColor = false;
            this.testSetupButton.Click += new System.EventHandler(this.testSetupButton_Click);
            this.testSetupButton.MouseHover += new System.EventHandler(this.setupHover);
            // 
            // rubrikButton
            // 
            this.rubrikButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rubrikButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rubrikButton.Location = new System.Drawing.Point(230, 500);
            this.rubrikButton.Name = "rubrikButton";
            this.rubrikButton.Size = new System.Drawing.Size(255, 105);
            this.rubrikButton.TabIndex = 2;
            this.rubrikButton.Text = "View marks";
            this.rubrikButton.UseVisualStyleBackColor = false;
            this.rubrikButton.Click += new System.EventHandler(this.rubrikButton_Click);
            this.rubrikButton.MouseHover += new System.EventHandler(this.rubrikHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(21, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome lecturer";
            // 
            // LECTURERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(738, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rubrikButton);
            this.Controls.Add(this.testSetupButton);
            this.Controls.Add(this.backButton1);
            this.Name = "LECTURERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LECTURERS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Button testSetupButton;
        private System.Windows.Forms.Button rubrikButton;
        private System.Windows.Forms.Label label1;
    }
}