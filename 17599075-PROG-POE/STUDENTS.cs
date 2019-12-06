using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17599075_PROG_POE
{
    public partial class STUDENTS : Form
    {
        private string UserName;
        public STUDENTS(string username)
        {
            InitializeComponent();
            UserName = username;
        }
        ToolTip t1 = new ToolTip();  // Mouse Hover "help"
        private void backButton2_Click(object sender, EventArgs e) //Back button (back to login window)
        {
            this.Hide();
            LOGIN log = new LOGIN();
            log.ShowDialog();
        }

        private void backHover(object sender, EventArgs e) // Mouse Hover "help"
        {
            t1.Show("Back", backButton2);
        }

        private void takeTestHover(object sender, EventArgs e)
        {
            t1.Show("Take test", takeTestButton);
        }

        private void viewMarkHover(object sender, EventArgs e)
        {
            t1.Show("View mark", marksButton);
        }

        

        private void takeTestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            takeTest tt = new takeTest(UserName);
            tt.ShowDialog();
        }

        private void marksButton_Click(object sender, EventArgs e)
        {
            ViewMemo vm = new ViewMemo(UserName);
            this.Hide();
            vm.Show();
        }
    }
}
