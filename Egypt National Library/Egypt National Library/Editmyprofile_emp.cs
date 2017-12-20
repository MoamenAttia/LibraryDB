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
    public partial class Editmyprofile_emp : Form
    {
        EmployeeForm ef;
        ManagerForm mf;
        ChairmanForm cf;
        string id;
        string nme;
        Controller cobj;
        public Editmyprofile_emp(ManagerForm m, ChairmanForm c, EmployeeForm e,string n,string i)
        {
            id = i;
            nme = n;
            mf = m;
            cf = c;
            cobj = new Controller();
            ef = e;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ef != null)
                ef.Show();
            else if (mf != null)
                mf.Show();
            else if (cf != null)
                cf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ef != null)
                ef.Show();
            else if (mf != null)
                mf.Show();
            else if (cf != null)
                cf.Show();
            Environment.Exit(1);
        }

        private void Pas_Click(object sender, EventArgs e)
        {
            this.Hide();
            editpass f = new editpass(this,id);
            f.Show();
        }

        private void Editmyprofile_emp_Load(object sender, EventArgs e)
        {
            label4.Text = nme;
            label5.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            editaddress f = new editaddress(this,Convert.ToInt32(id));
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            editimage f = new editimage(this,Convert.ToInt32(id));
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            editneeds f = new editneeds(this,Convert.ToInt32(id));
            f.Show();
        }
    }
}
