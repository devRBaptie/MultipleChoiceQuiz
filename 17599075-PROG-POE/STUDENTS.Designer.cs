namespace _17599075_PROG_POE
{
    partial class STUDENTS
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
            this.backButton2 = new System.Windows.Forms.Button();
            this.takeTestButton = new System.Windows.Forms.Button();
            this.marksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton2
            // 
            this.backButton2.BackColor = System.Drawing.Color.Silver;
            this.backButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton2.Location = new System.Drawing.Point(30, 30);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(135, 70);
            this.backButton2.TabIndex = 0;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = false;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            this.backButton2.MouseHover += new System.EventHandler(this.backHover);
            // 
            // takeTestButton
            // 
            this.takeTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.takeTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takeTestButton.Location = new System.Drawing.Point(228, 250);
            this.takeTestButton.Name = "takeTestButton";
            this.takeTestButton.Size = new System.Drawing.Size(250, 100);
            this.takeTestButton.TabIndex = 1;
            this.takeTestButton.Text = "Take Test";
            this.takeTestButton.UseVisualStyleBackColor = false;
            this.takeTestButton.Click += new System.EventHandler(this.takeTestButton_Click);
            this.takeTestButton.MouseHover += new System.EventHandler(this.takeTestHover);
            // 
            // marksButton
            // 
            this.marksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.marksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marksButton.Location = new System.Drawing.Point(228, 477);
            this.marksButton.Name = "marksButton";
            this.marksButton.Size = new System.Drawing.Size(250, 100);
            this.marksButton.TabIndex = 2;
            this.marksButton.Text = "View Mark";
            this.marksButton.UseVisualStyleBackColor = false;
            this.marksButton.Click += new System.EventHandler(this.marksButton_Click);
            this.marksButton.MouseHover += new System.EventHandler(this.viewMarkHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(30, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome Student";
            // 
            // STUDENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(738, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marksButton);
            this.Controls.Add(this.takeTestButton);
            this.Controls.Add(this.backButton2);
            this.Name = "STUDENTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Button takeTestButton;
        private System.Windows.Forms.Button marksButton;
        private System.Windows.Forms.Label label1;
    }
}