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
    public partial class LOGIN : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public LOGIN()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source = |DataDirectory|/POE_Database.accdb;" +
                                            "Persist Security Info = False;";
        }
        

        List<string> user = new List<string>();
        List<string> pass = new List<string>();
        public string UserName;
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "Select * From STUDENTS Where [USERNAME] = '" + usernameTextBox.Text + "' AND [PASSWORD] = '" + passwordTextBox.Text + "' ;";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }

            if ((usernameTextBox.Text == "admin") && (passwordTextBox.Text == "Password1"))
            {
                
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                usernameTextBox.BackColor = Color.White;
                passwordTextBox.BackColor = Color.White;
                MessageBox.Show("Login successful", "Sucessful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LECTURERS lec = new LECTURERS();
                lec.ShowDialog();
                

            }
            else if (count == 1)
            {
                connection.Close();
                connection.Dispose();
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                usernameTextBox.BackColor = Color.White;
                passwordTextBox.BackColor = Color.White;
                
                MessageBox.Show("Login successful", "Sucessful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                              
                STUDENTS stu = new STUDENTS(usernameTextBox.Text);
                stu.ShowDialog();
                
            }else
            {
                if (reader["USERNAME"].ToString().Equals(usernameTextBox.Text))
                {

                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Red;
                    usernameTextBox.BackColor = Color.White;
                    passwordTextBox.BackColor = Color.MistyRose;

                    passwordTextBox.Clear();
                    passwordTextBox.Focus();

                    MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label2.ForeColor = Color.Red;
                    usernameTextBox.BackColor = Color.MistyRose;
                    passwordTextBox.BackColor = Color.MistyRose;

                    usernameTextBox.Clear();
                    passwordTextBox.Clear();

                    usernameTextBox.Focus();

                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connLabel.Text = "Connection successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connLabel.Text = "Connection unsuccessful";
            }
           /*
            *try
            {
                StreamReader sr = new StreamReader("login.txt");
                string line = "";

                while ((line = sr.ReadLine()) != null)
                {

                    string[] comp = line.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    user.Add(comp[0]);
                    pass.Add(comp[1]);

                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
       
        
            
            
   
    }
}
