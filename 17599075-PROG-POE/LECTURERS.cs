using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17599075_PROG_POE
{
    public partial class LECTURERS : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public LECTURERS()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; " +
                                           "Data Source = |DataDirectory|/POE_Database.accdb;" +
                                            "Persist Security Info = False;";
        }

        ToolTip t1 = new ToolTip();

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN log = new LOGIN();
            log.ShowDialog();
        }

        
        private void backHover(object sender, EventArgs e)
        {
           t1.Show("Back", backButton1);
        }

        private void setupHover(object sender, EventArgs e)
        {
            t1.Show("Set up a new test", testSetupButton);
        }

        private void rubrikHover(object sender, EventArgs e)
        {
            t1.Show("View class marks", rubrikButton);
        }

        private void testSetupButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("If you continue all previous test data will be erased, do you wish to continnue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {
                case DialogResult.Yes:      // Create new test
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE * FROM QUIZ;";// Clears database for New Test
                    command.ExecuteNonQuery();


                    command.CommandText = "ALTER TABLE QUIZ ALTER COLUMN [ID] AUTOINCREMENT(1, 1);"; // Reset Primary key
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                    this.Hide();
                    testSetup tset = new testSetup();
                    tset.ShowDialog();
                    break;
                case DialogResult.No:          // Stop
                    LECTURERS lec = new LECTURERS();
                    lec.ShowDialog();
                    break;
            }
            
            
        }

        private void rubrikButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ClassMarks cm = new ClassMarks();
            cm.Show();
        }
    }
}
