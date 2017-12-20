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
    public partial class GetStatistics : Form
    {
        DataTable Dt;
        double amount;
        ManagerForm mf;
        string nme;
        string id;
        Controller cobj;
        public GetStatistics(ManagerForm m,string n, string i)
        {
            nme = n;
            id = i;
            amount = 0;
            mf = m;
            InitializeComponent();
            cobj = new Controller();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            mf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            mf.Close();
            Environment.Exit(1);

        }

        private void av_Click(object sender, EventArgs e)
        {
            Dt = cobj.AVG_Sal_Under_Manager(Convert.ToInt32(id));
            if (Convert.ToString(Dt.Rows[0]["AVG_Salaries"]) == "")
                amount = 0;
            else
                amount = Convert.ToDouble(Dt.Rows[0]["AVG_Salaries"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(this, null, "AVG Salary", amount.ToString());
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dt = cobj.Total_Sal_Under_Manager(Convert.ToInt32(id));
            if (Convert.ToString(Dt.Rows[0]["Total_salary"]) == "")
                amount = 0;
            else
                amount = Convert.ToDouble(Dt.Rows[0]["Total_salary"]); this.Hide();
            statisticsveiwer f = new statisticsveiwer(this, null, "Total Salaries", amount.ToString());
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dt = cobj.AVG_Age_Under_Manager(Convert.ToInt32(id));
            if (Convert.ToString(Dt.Rows[0]["AVG_Age"]) == "")
                amount = 0;
            else
                amount = Convert.ToDouble(Dt.Rows[0]["AVG_Age"]); this.Hide();
            statisticsveiwer f = new statisticsveiwer(this, null, "AVG Age", amount.ToString());
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dt = cobj.Count_Employees_under_Manager(Convert.ToInt32(id));
            amount = Convert.ToDouble(Dt.Rows[0]["N_Of_Emp"]);
            this.Hide();
            statisticsveiwer f = new statisticsveiwer(this, null, "Emp Count", amount.ToString());
            f.Show();
        }

        private void GetStatistics_Load(object sender, EventArgs e)
        {
            label1.Text = nme;
            label4.Text = id;
        }
    }
}
