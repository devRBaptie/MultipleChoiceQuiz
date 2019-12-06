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
    public partial class ViewMemo : Form
    {
        private string UserName;
        private OleDbConnection connection = new OleDbConnection();
        public ViewMemo(string UserName)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; " +
                                            "Data Source = |DataDirectory|/POE_Database.accdb;" +
                                            "Persist Security Info = False;";
            this.UserName = UserName;
        }
        ToolTip t1 = new ToolTip();  // Mouse Hover "help"
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            STUDENTS stu = new STUDENTS("");
            stu.ShowDialog();
        }
        List<string> quest = new List<string>();
        List<string> solA = new List<string>();
        List<string> solB = new List<string>();
        List<string> solC = new List<string>();
        List<string> ans = new List<string>();

        public int totnum = 0;
        public int num = 0;


        private void ViewMemo_Load(object sender, EventArgs e)
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
            NextQuestion();

        }

        public void NextQuestion()
        {
                     

            num = quest.Count;
            navLabel.Text = (totnum + 1) + "/" + num;

            if (totnum > 0)
            {
                backButton1.Visible = true;
            }
            else    // Question 1
            {
                backButton1.Visible = false;
            }

            if (totnum + 1 == num)  // Last question
            {
                NextButton.Visible = false;
                finishButton.Visible = true;
            }
            else
            {
                NextButton.Visible = true;
                finishButton.Visible = false;
            }

            string answer="";
            QuestionNumLabel.Text = "Question " + (totnum + 1)+":";
            QuestionLabel.Text = quest[totnum];
            SolAansLabel.Text = "Sol A: "+solA[totnum];
            SolBansLabel.Text = "Sol B: " + solB[totnum];
            SolCansLabel.Text = "Sol C: " + solC[totnum];

            switch (int.Parse(ans[totnum]))
            {
                case 0:
                    answer = "A";
                    break;
                case 1:
                    answer = "B";
                    break;
                case 2:
                    answer = "C";
                    break;
            }

            correctAnsLabel.Text = "Correct Answer: " + answer;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            totnum = totnum + 1; // next question
            NextQuestion();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            STUDENTS stu = new STUDENTS(UserName);
            stu.ShowDialog();
        }
    }
}
