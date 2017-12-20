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
    public partial class statisticsveiwer : Form
    {
        GetStatistics mf;
        getstateschmode cf;
        string title;
        string amount;
        Controller cobj;
        DataTable Dt;
        public statisticsveiwer(GetStatistics m, getstateschmode c, string t,string a)
        {
            mf = m;
            cf = c;
            title = t;
            amount = a;
            InitializeComponent();
        }

        private void statisticsveiwer_Load(object sender, EventArgs e)
        {
            label1.Text = amount;
            label3.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Close();
            else if (mf != null)
                mf.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Show();
            else if (mf != null)
                mf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
