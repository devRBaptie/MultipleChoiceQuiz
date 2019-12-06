namespace _17599075_PROG_POE
{
    partial class ClassMarks
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
            this.components = new System.ComponentModel.Container();
            this.backButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.highestMarkLabel = new System.Windows.Forms.Label();
            this.lowestMarkLabel = new System.Windows.Forms.Label();
            this.ClassAverageLabel = new System.Windows.Forms.Label();
            this.ClassHighLabel = new System.Windows.Forms.Label();
            this.ClassLowLabel = new System.Windows.Forms.Label();
            this.sTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRangeLabel = new System.Windows.Forms.Label();
            this.markRangeLabel = new System.Windows.Forms.Label();
            this.sTUDENTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pOEDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOE_DataSetApp = new _17599075_PROG_POE.POE_DataSetApp();
            this.pOEDataSetAppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTUDENTSBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSTableAdapter = new _17599075_PROG_POE.POE_DataSetAppTableAdapters.STUDENTSTableAdapter();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOEDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOE_DataSetApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOEDataSetAppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 72);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(736, 728);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(207, 32);
            this.averageLabel.TabIndex = 2;
            this.averageLabel.Text = "Class Average:";
            // 
            // highestMarkLabel
            // 
            this.highestMarkLabel.AutoSize = true;
            this.highestMarkLabel.Location = new System.Drawing.Point(71, 728);
            this.highestMarkLabel.Name = "highestMarkLabel";
            this.highestMarkLabel.Size = new System.Drawing.Size(160, 32);
            this.highestMarkLabel.TabIndex = 3;
            this.highestMarkLabel.Text = "Class High:";
            // 
            // lowestMarkLabel
            // 
            this.lowestMarkLabel.AutoSize = true;
            this.lowestMarkLabel.Location = new System.Drawing.Point(71, 802);
            this.lowestMarkLabel.Name = "lowestMarkLabel";
            this.lowestMarkLabel.Size = new System.Drawing.Size(160, 32);
            this.lowestMarkLabel.TabIndex = 4;
            this.lowestMarkLabel.Text = "Class Low: ";
            // 
            // ClassAverageLabel
            // 
            this.ClassAverageLabel.AutoSize = true;
            this.ClassAverageLabel.Location = new System.Drawing.Point(1004, 728);
            this.ClassAverageLabel.Name = "ClassAverageLabel";
            this.ClassAverageLabel.Size = new System.Drawing.Size(31, 32);
            this.ClassAverageLabel.TabIndex = 5;
            this.ClassAverageLabel.Text = "1";
            // 
            // ClassHighLabel
            // 
            this.ClassHighLabel.AutoSize = true;
            this.ClassHighLabel.Location = new System.Drawing.Point(272, 728);
            this.ClassHighLabel.Name = "ClassHighLabel";
            this.ClassHighLabel.Size = new System.Drawing.Size(31, 32);
            this.ClassHighLabel.TabIndex = 6;
            this.ClassHighLabel.Text = "1";
            // 
            // ClassLowLabel
            // 
            this.ClassLowLabel.AutoSize = true;
            this.ClassLowLabel.Location = new System.Drawing.Point(262, 802);
            this.ClassLowLabel.Name = "ClassLowLabel";
            this.ClassLowLabel.Size = new System.Drawing.Size(31, 32);
            this.ClassLowLabel.TabIndex = 7;
            this.ClassLowLabel.Text = "1";
            // 
            // sTUDENTSBindingSource
            // 
            this.sTUDENTSBindingSource.DataMember = "STUDENTS";
            // 
            // classRangeLabel
            // 
            this.classRangeLabel.AutoSize = true;
            this.classRangeLabel.Location = new System.Drawing.Point(592, 728);
            this.classRangeLabel.Name = "classRangeLabel";
            this.classRangeLabel.Size = new System.Drawing.Size(31, 32);
            this.classRangeLabel.TabIndex = 10;
            this.classRangeLabel.Text = "1";
            // 
            // markRangeLabel
            // 
            this.markRangeLabel.AutoSize = true;
            this.markRangeLabel.Location = new System.Drawing.Point(401, 728);
            this.markRangeLabel.Name = "markRangeLabel";
            this.markRangeLabel.Size = new System.Drawing.Size(192, 32);
            this.markRangeLabel.TabIndex = 9;
            this.markRangeLabel.Text = "Class Range: ";
            // 
            // sTUDENTSBindingSource1
            // 
            this.sTUDENTSBindingSource1.DataMember = "STUDENTS";
            // 
            // sTUDENTSBindingSource3
            // 
            this.sTUDENTSBindingSource3.DataMember = "STUDENTS";
            // 
            // sTUDENTSBindingSource2
            // 
            this.sTUDENTSBindingSource2.DataMember = "STUDENTS";
            // 
            // pOE_DataSetApp
            // 
            this.pOE_DataSetApp.DataSetName = "POE_DataSetApp";
            this.pOE_DataSetApp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOEDataSetAppBindingSource
            // 
            this.pOEDataSetAppBindingSource.DataSource = this.pOE_DataSetApp;
            this.pOEDataSetAppBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView1.DataSource = this.sTUDENTSBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(77, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(935, 527);
            this.dataGridView1.TabIndex = 11;
            // 
            // sTUDENTSBindingSource4
            // 
            this.sTUDENTSBindingSource4.DataMember = "STUDENTS";
            this.sTUDENTSBindingSource4.DataSource = this.pOEDataSetAppBindingSource;
            // 
            // sTUDENTSTableAdapter
            // 
            this.sTUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "USERNAME";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PASSWORD";
            this.dataGridViewTextBoxColumn7.HeaderText = "PASSWORD";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FIRSTNAME";
            this.dataGridViewTextBoxColumn8.HeaderText = "FIRSTNAME";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SURNAME";
            this.dataGridViewTextBoxColumn9.HeaderText = "SURNAME";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TEST_MARK";
            this.dataGridViewTextBoxColumn10.HeaderText = "TEST_MARK";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // ClassMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1218, 985);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.classRangeLabel);
            this.Controls.Add(this.markRangeLabel);
            this.Controls.Add(this.ClassLowLabel);
            this.Controls.Add(this.ClassHighLabel);
            this.Controls.Add(this.ClassAverageLabel);
            this.Controls.Add(this.lowestMarkLabel);
            this.Controls.Add(this.highestMarkLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.backButton);
            this.Name = "ClassMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassMarks";
            this.Load += new System.EventHandler(this.ClassMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOEDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOE_DataSetApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOEDataSetAppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label highestMarkLabel;
        private System.Windows.Forms.Label lowestMarkLabel;
        private System.Windows.Forms.Label ClassAverageLabel;
        private System.Windows.Forms.Label ClassHighLabel;
        private System.Windows.Forms.Label ClassLowLabel;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource;
        private System.Windows.Forms.Label classRangeLabel;
        private System.Windows.Forms.Label markRangeLabel;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource1;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTMARKDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource3;
        private System.Windows.Forms.BindingSource pOEDatabaseDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private POE_DataSetApp pOE_DataSetApp;
        private System.Windows.Forms.BindingSource pOEDataSetAppBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource4;
        private POE_DataSetAppTableAdapters.STUDENTSTableAdapter sTUDENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}