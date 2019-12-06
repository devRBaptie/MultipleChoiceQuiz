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
    public partial class takeTest : Form
    {
        private string UserName;
        private OleDbConnection connection = new OleDbConnection();
        public takeTest(string numValue)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source = |DataDirectory|/POE_Database.accdb;" +
                                            "Persist Security Info = False;";

            UserName = numValue;
        }
        public int totnum = 0;
        public int num=0;
        public int Marks=0;
        List<string> quest = new List<string>();
        List<string> solA = new List<string>();
        List<string> solB = new List<string>();
        List<string> solC = new List<string>();
        List<string> ans = new List<string>();

        public int[] userAns = new int[20];
        private void takeTest_Load(object sender, EventArgs e)  // window open
        {
           
            backButton2.Visible = false;
            submitButton.Visible = false;
            nextButton.Visible = true;            

            loadQuestion();
            
            NextQuestion();
        }        
        public void loadQuestion()  // Loads next question
        {
            try
            { 
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM QUIZ";

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quest.Add(reader["QUESTION"].ToString());
                    solA.Add(reader["SOL_A"].ToString());
                    solB.Add(reader["SOL_B"].ToString());
                    solC.Add(reader["SOL_C"].ToString());
                    ans.Add(reader["CORRECT_ANSWER"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
      }               

        private void nextButton_Click(object sender, EventArgs e)
        {
            
            if (solARadio.Checked || solBRadio.Checked || solCRadio.Checked && totnum<=num)
            {
                if (solARadio.Checked)  // keep selection
                {
                    userAns[totnum] = 1;
                }
                if (solBRadio.Checked)  // keep selection
                {
                    userAns[totnum] = 2;
                }
                if (solCRadio.Checked)  // keep selection
                {
                    userAns[totnum] = 3;
                }

                solARadio.ForeColor = Color.Black;
                solBRadio.ForeColor = Color.Black;
                solCRadio.ForeColor = Color.Black;
               
                totnum = totnum + 1; // next question
                NextQuestion();
                
            }
            else // Invalid selection
            {                
                solARadio.ForeColor= Color.Red;
                solBRadio.ForeColor = Color.Red;
                solCRadio.ForeColor = Color.Red;                
            }

        }   

        public void NextQuestion()
        {

            solARadio.Checked = false;
            solBRadio.Checked = false;
            solCRadio.Checked = false;

            num = quest.Count;
            navLabel.Text = (totnum + 1) + "/" + num;

            if (totnum > 0) 
            {
                backButton2.Visible = true;
            }
            else    // Question 1
            {
                backButton2.Visible = false;
            }

            if (totnum + 1 == num)  // Last question
            {
                nextButton.Visible = false;
                submitButton.Visible = true;
            }else
            {
                nextButton.Visible = true;
                submitButton.Visible = false;
            }


            if(userAns[totnum].ToString() != null)
            {
                switch (userAns[totnum])
                {
                    case 1:
                        solARadio.Checked = true;
                        break;
                    case 2:
                        solBRadio.Checked = true;
                        break;
                    case 3:
                        solCRadio.Checked = true;
                        break;
                }
            }
            

            quesNumLabel.Text = "Question " + (totnum + 1);
            QuestionLabel.Text = quest[totnum];
            solARadio.Text = solA[totnum];
            solBRadio.Text = solB[totnum];
            solCRadio.Text = solC[totnum];            
           
        }

        private void backButton2_Click(object sender, EventArgs e)      // Previous question
                {
                    if (solARadio.Checked)  // keep selection
                    {
                        userAns[totnum] = 1;
                    }
                    if (solBRadio.Checked)  // keep selection
                    {
                        userAns[totnum] = 2;
                    }
                    if (solCRadio.Checked)  // keep selection
                    {
                        userAns[totnum] = 3;
                    }


                    totnum = totnum - 1;
                    if (totnum == 0)
                    {
                        backButton2.Visible = false;
                    }
                    if (totnum + 1 == num)  // Last question
                    {
                        nextButton.Visible = false;
                        submitButton.Visible = true;
                    }
                    else
                    {
                        nextButton.Visible = true;
                        submitButton.Visible = false;
                    }
                    num = quest.Count;
                    navLabel.Text = (totnum + 1) + "/" + num;

                    if (userAns[totnum].ToString() != null)
                    {
                        switch (userAns[totnum])
                        {
                            case 1:
                                solARadio.Checked = true;
                                userAns[totnum] = 0;
                                break;
                            case 2:
                                solBRadio.Checked = true;
                                userAns[totnum] = 1;
                                break;
                            case 3:
                                solCRadio.Checked = true;
                                userAns[totnum] = 2;
                                break;
                        }
                    }
            

                    quesNumLabel.Text = "Question " + (totnum + 1);
                    QuestionLabel.Text = quest[totnum];
                    solARadio.Text = solA[totnum];
                    solBRadio.Text = solB[totnum];
                    solCRadio.Text = solC[totnum];
                }


        private void submitButton_Click(object sender, EventArgs e)     //  save & submit button
        {
                      
            marks();
            
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string sql = "UPDATE STUDENTS SET  [TEST_MARK] ='"+Marks+"' WHERE USERNAME = '"+UserName.ToString()+"'";
                
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            MessageBox.Show("Your Test Marks is: "+ Marks+"/"+num, "Test Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            STUDENTS stu = new STUDENTS(UserName);
            stu.Show();
            
        }  
        
        public void marks()
        {
            for(int i = 0; i < num; i++)
            {
                if (int.Parse(ans[i]) == userAns[i]-1)
                {
                    Marks = Marks + 1;

                }
            }
        }
        
    }
}
