using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_National_Library
{
    public partial class getstateschmode : Form
    {
        ChairmanForm cf;
        Controller cobj;
        DataTable Dt;
        double amount;
        public getstateschmode(ChairmanForm c)
        {
            amount = 0;
            cf = c;
            InitializeComponent();
            cobj = new Controller();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Close();
            Environment.Exit(1);

        }

        private void av_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_AVG_Sal();
            if (Convert.ToString(Dt.Rows[0]["avg_Salary"]) == "")
                amount = 0;
            else
                amount = Convert.ToDouble(Dt.Rows[0]["avg_Salary"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "avg_salary", amount.ToString());
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i;
            if(textBox1.Text == ""|| !int.TryParse(textBox1.Text,out i))
            {
                MsgShow ms = new MsgShow("Invalid MID");
                ms.ShowDialog();
                return;
            }
            Dt = cobj.AVG_Sal_Under_Manager(i);
            if (Convert.ToString(Dt.Rows[0]["AVG_Salaries"]) == "")
            {
                MsgShow ms = new MsgShow("Invalid MID");
                ms.ShowDialog();
                return;
            }
            else
                amount = Convert.ToDouble(Dt.Rows[0]["AVG_Salaries"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "AVG Salary", amount.ToString());
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || int.TryParse(textBox1.Text, out i))
            {
                MsgShow ms = new MsgShow("Invalid Job");
                ms.ShowDialog();
                return;
            }
            Dt = cobj.AVG_Sal_Under_Job(textBox1.Text);
            if (Convert.ToString(Dt.Rows[0]["AVG_Salaries"]) == "")
            {
                MsgShow ms = new MsgShow("Invalid Job");
                ms.ShowDialog();
                return;
            }
            else
                amount = Convert.ToDouble(Dt.Rows[0]["AVG_Salaries"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "AVG Salary", amount.ToString());
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || int.TryParse(textBox1.Text, out i))
            {
                MsgShow ms = new MsgShow("Invalid Job");
                ms.ShowDialog();
                return;
            }
            Dt = cobj.Total_Sal_Under_Job(textBox1.Text);
            if (Convert.ToString(Dt.Rows[0]["Total_salary"]) == "")
            {
                MsgShow ms = new MsgShow("Invalid Job");
                ms.ShowDialog();
                return;
            }
            else
                amount = Convert.ToDouble(Dt.Rows[0]["Total_salary"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "Total Salaries", amount.ToString());
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out i))
            {
                MsgShow ms = new MsgShow("Invalid MID");
                ms.ShowDialog();
                return;
            }
            Dt = cobj.Total_Sal_Under_Manager(i);
            if (Convert.ToString(Dt.Rows[0]["Total_salary"]) == "")
            {
                MsgShow ms = new MsgShow("Invalid MID");
                ms.ShowDialog();
                return;
            }
            else
                amount = Convert.ToDouble(Dt.Rows[0]["Total_salary"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "Total Salaries", amount.ToString());
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Total_Sal();
            if (Convert.ToString(Dt.Rows[0]["Total_salary"]) == "")
                amount = 0;
            else
                amount = Convert.ToDouble(Dt.Rows[0]["Total_salary"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "Total Salaries", amount.ToString());
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_AVG_Age();
            if (Convert.ToString(Dt.Rows[0]["AVG_Age"]) == "")
                amount = 0;
            else
                amount = Convert.ToDouble(Dt.Rows[0]["AVG_Age"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "AVG Age", amount.ToString());
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out i))
            {
                MsgShow ms = new MsgShow("Invalid MID");
                ms.ShowDialog();
                return;
            }
            Dt = cobj.AVG_Age_Under_Manager(i);
            if (Convert.ToString(Dt.Rows[0]["AVG_Age"]) == "")
            {
                MsgShow ms = new MsgShow("Invalid MID");
                ms.ShowDialog();
                return;
            }
            else
                amount = Convert.ToDouble(Dt.Rows[0]["AVG_Age"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "AVG Age", amount.ToString());
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || int.TryParse(textBox1.Text, out i))
            {
                MsgShow ms = new MsgShow("Invalid Job");
                ms.ShowDialog();
                return;
            }
            Dt = cobj.AVG_Age_Under_Job(textBox1.Text);
            if (Convert.ToString(Dt.Rows[0]["AVG_Age"]) == "")
            {
                MsgShow ms = new MsgShow("Invalid Job");
                ms.ShowDialog();
                return;
            }
            else
                amount = Convert.ToDouble(Dt.Rows[0]["AVG_Age"]);

            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "AVG Age", amount.ToString());
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dt = cobj.Count_Employees();
            if (Convert.ToString(Dt.Rows[0]["N_Of_Emp"]) == "")
                amount = 0;
            else
                amount = Convert.ToDouble(Dt.Rows[0]["N_Of_Emp"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "Emp Count", amount.ToString());
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out i))
            {
                MsgShow ms = new MsgShow("Invalid MID");
                ms.ShowDialog();
                return;
            }
            Dt = cobj.Count_Employees_under_Manager(i);
            if (Convert.ToString(Dt.Rows[0]["N_Of_Emp"]) == "")
            {
                MsgShow ms = new MsgShow("Invalid MID");
                ms.ShowDialog();
                return;
            }
            else
                amount = Convert.ToDouble(Dt.Rows[0]["N_Of_Emp"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "Emp Count", amount.ToString());
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || int.TryParse(textBox1.Text, out i))
            {
                MsgShow ms = new MsgShow("Invalid Job");
                ms.ShowDialog();
                return;
            }
            Dt = cobj.Count_Employees_under_Job(textBox1.Text);
            if (Convert.ToString(Dt.Rows[0]["N_Of_Emp"]) == "")
            {
                MsgShow ms = new MsgShow("Invalid Job");
                ms.ShowDialog();
                return;
            }
            else
                amount = Convert.ToDouble(Dt.Rows[0]["N_Of_Emp"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(null, this, "Emp Count", amount.ToString());
            f.Show();
        }
    }
}
