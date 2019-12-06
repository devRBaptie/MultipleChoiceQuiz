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
    public partial class ClassMarks : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public ClassMarks()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source = |DataDirectory|/POE_Database.accdb;" +
                                            "Persist Security Info = False;";
        }
      

        public int tot=0;
        public double average=0;        
        public int num = 0;
        public int min = 0;
        public int max = 0;
        public int range = 0;
        //private string line = "";
        private void ClassMarks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOE_DataSetApp.STUDENTS' table. You can move, or remove it, as needed.
            this.sTUDENTSTableAdapter.Fill(this.pOE_DataSetApp.STUDENTS);



            try
            {               

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM STUDENTS";

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(reader["TEST_MARK"].ToString()) > max)
                    {
                        max = int.Parse(reader["TEST_MARK"].ToString());    // Highest Mark
                    }
                    if (int.Parse(reader["TEST_MARK"].ToString()) < min)    
                    {
                        min = int.Parse(reader["TEST_MARK"].ToString());    //Lowest Mark
                    }
                    num = num + 1;
                    tot = tot + int.Parse(reader["TEST_MARK"].ToString());  // Total
                }
                reader.Close();
                
                ClassAverageLabel.Text = (tot / num).ToString();    // Display Average
                
                ClassLowLabel.Text = min.ToString();                // Display Lowest Mark

                ClassHighLabel.Text = max.ToString();               // Display Highest Mark

                range = max - min;
                classRangeLabel.Text = range.ToString();            // Display Range
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            connection.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LECTURERS lec = new LECTURERS();
            lec.Show();
        }
    }
}
