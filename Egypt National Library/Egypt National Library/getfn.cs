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
    public partial class getfn : Form
    {
        GetInfoofEmp mf;
        getempinfochmode cf;
        DataTable Dt;
        public getfn(GetInfoofEmp m , getempinfochmode c,DataTable d)
        {
            Dt = d;
            mf = m;
            cf = c;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Show();
            else if (mf != null)
                mf.Show();
        }

        private void getfn_Load(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Dt.Rows[0]["Fname"]) + " " +
                Convert.ToString(Dt.Rows[0]["Mname"]) + " " +
                Convert.ToString(Dt.Rows[0]["Lname"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Close();
            else if (mf != null)
                mf.Close();
        }
    }
}
