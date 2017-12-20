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
    public partial class getempbychmode : Form
    {
        ChairmanForm cf;
        string id;
        string nme;
        public getempbychmode(ChairmanForm c,string n,string i)
        {
            nme = n;
            id = i;
            cf = c;
            InitializeComponent();
        }

        private void getempbychmode_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Close();
            Environment.Exit(1);

        }

        private void Fn_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyf f = new getempbyf(null, this,1);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyfl f = new getempbyfl(null,this, 1);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyfn f = new getempbyfn(null, this, 1);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyid f = new getempbyid(null, this, 1);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyage f = new getempbyage(null, this, 1);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyjob f = new getempbyjob(null, this, 1);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbyaddress f = new getempbyaddress(null, this, 1);
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbymid f = new getempbymid(null, this);
            f.Show();       
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbysal f = new getempbysal(null, this, 1);
            f.Show();
        }
    }
}
