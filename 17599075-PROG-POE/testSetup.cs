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
    public partial class testSetup : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public testSetup()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source = |DataDirectory|/POE_Database.accdb;" +
                                            "Persist Security Info = False;";
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LECTURERS lec = new LECTURERS();
            lec.ShowDialog();
        }  // Back button

        private void createButton_Click(object sender, EventArgs e)
        {
            Boolean flag2 = true;
            flag2 = dataValdation();
           // string ques = "";
            

            if (flag2==true)    // data validated
            {
                try
                {

                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string sql = "INSERT into QUIZ ([QUESTION] , [SOL_A], [SOL_B], [SOL_C], [CORRECT_ANSWER]) Values('" + enterQTextBox1.Text + "' , '" + solATextBox2.Text + "' , '" + solBTextBox3.Text + "' , '" + solCTextBox4.Text + "' , '" + comboBox1.SelectedIndex + "')";
                    MessageBox.Show(sql);
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                    connection.Close();

                }
                
                this.Hide();
                DialogResult dr = MessageBox.Show("You have successfully added a question, Do you want to add another?","Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        testSetup ts = new testSetup();
                        ts.ShowDialog();
                        break;
                    case DialogResult.No:          // Stop
                        LECTURERS lec = new LECTURERS();
                        lec.ShowDialog();
                        break;
                }
            }
        }

        public Boolean dataValdation()
        {
            Boolean flag = true;

            if (string.IsNullOrEmpty(enterQTextBox1.Text))
            {
                enterQLabel1.ForeColor = Color.Red;
                enterQTextBox1.BackColor = Color.MistyRose;
            }
            else
            {
                enterQLabel1.ForeColor = Color.Black;
                enterQTextBox1.BackColor = Color.White;
                flag = true;
            }
            if (string.IsNullOrEmpty(solATextBox2.Text))
            {
                solALabel2.ForeColor = Color.Red;
                solATextBox2.BackColor = Color.MistyRose;
            }
            else
            {
                solALabel2.ForeColor = Color.Black;
                solATextBox2.BackColor = Color.White;
                flag = true;
            }
            if (string.IsNullOrEmpty(solBTextBox3.Text))
            {
                solBLabel3.ForeColor = Color.Red;
                solBTextBox3.BackColor = Color.MistyRose;
            }
            else
            {
                solBLabel3.ForeColor = Color.Black;
                solBTextBox3.BackColor = Color.White;
                flag = true;
            }
            if (string.IsNullOrEmpty(solCTextBox4.Text))
            {
                solCLabel4.ForeColor = Color.Red;
                solCTextBox4.BackColor = Color.MistyRose;
            }
            else
            {
                solCLabel4.ForeColor = Color.Black;
                solCTextBox4.BackColor = Color.White;
                flag = true;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                answerLabel5.ForeColor = Color.Red;
                comboBox1.BackColor = Color.MistyRose;
            }
            else
            {
                answerLabel5.ForeColor = Color.Black;
                comboBox1.BackColor = Color.White;
                flag = true;
            }

            if ((string.IsNullOrEmpty(enterQTextBox1.Text)) || (string.IsNullOrEmpty(solATextBox2.Text)) || (string.IsNullOrEmpty(solBTextBox3.Text)) || (string.IsNullOrEmpty(solCTextBox4.Text)) || (comboBox1.SelectedIndex == -1))
            {
                flag = false;
                MessageBox.Show("Fill required fields","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return flag;
        }

        ToolTip t1 = new ToolTip();
        private void backHover(object sender, EventArgs e)
        {
            t1.Show("Back", backButton3);
        }

        private void createHover(object sender, EventArgs e)
        {
            t1.Show("Create question", createButton);
        }
    }
}
