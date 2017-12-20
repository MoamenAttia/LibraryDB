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
    public partial class getaddress : Form
    {
        GetInfoofEmp mf;
        getempinfochmode cf;
        DataTable Dt;
        public getaddress(GetInfoofEmp m, getempinfochmode c,DataTable d)
        {
            Dt = d;
            mf = m;
            cf = c;
            InitializeComponent();
        }

        private void getaddress_Load(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Dt.Rows[0]["Address"]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Show();
            else if (mf != null)
                mf.Show();
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
