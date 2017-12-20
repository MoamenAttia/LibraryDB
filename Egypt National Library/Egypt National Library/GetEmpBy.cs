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
    public partial class GetEmpBy : Form
    {
        ManagerForm mf;
        Controller cobj;
        string id1;
        string nme;
        public GetEmpBy(ManagerForm m, string n, string i)
        {
            nme = n;
            id1 = i;
            mf = m;
            InitializeComponent();
        }

        private void Fn_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyf f = new getempbyf(this, null,Convert.ToInt32(id1));
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyfl f = new getempbyfl(this, null, Convert.ToInt32(id1));
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyfn f = new getempbyfn(this, null, Convert.ToInt32(id1));
            f.Show();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyid f = new getempbyid(this, null, Convert.ToInt32(id1));
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyage f = new getempbyage(this, null, Convert.ToInt32(id1));
            f.Show();           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyjob f = new getempbyjob(this, null, Convert.ToInt32(id1));
            f.Show();            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyaddress f = new getempbyaddress(this, null, Convert.ToInt32(id1));
            f.Show();           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            mf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            mf.Close();
            Environment.Exit(1);
        }

        private void GetEmpBy_Load(object sender, EventArgs e)
        {
            label6.Text = nme;
            label4.Text = id1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbysal f = new getempbysal(this, null, Convert.ToInt32(id1));
            f.Show();
        }
    }
}
