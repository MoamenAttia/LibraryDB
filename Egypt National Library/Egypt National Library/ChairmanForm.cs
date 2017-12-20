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
    public partial class ChairmanForm : Form
    {
        string nme;
        Login_Form lf;
        Controller cobj;
        DataTable Dt;
        public ChairmanForm(Login_Form l,string n)
        {
            cobj = new Controller();
            nme = n;     
            InitializeComponent();
            lf = l;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_All_Emp();
            if (Dt != null)
            {
                this.Hide();
                Showmyemp f = new Showmyemp(null, this, Dt);
                f.Show();
            }
            else
            {
                MsgShow mm = new MsgShow("No Emp For You!");
                mm.ShowDialog();
            }
        }

        private void Get_Emp_By_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempbychmode f = new getempbychmode(this,nme,"1");
            f.Show();           
        }

        private void GET_Stat_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            getstateschmode f = new getstateschmode(this);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void Get_Info_By_ID_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            getempinfochmode f = new getempinfochmode(this);
            f.Show();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditemSalarypchmode f = new EditemSalarypchmode(this);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FireEmployee f = new FireEmployee(this);
            f.Show();
        }

        private void ChairmanForm_Load(object sender, EventArgs e)
        {
            name.Text = nme;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee_Form f = new Add_Employee_Form(this);
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editmyprofile_emp f = new Editmyprofile_emp(null, this, null, nme, "1");
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_All_Managers();
            if (Dt != null )
            {
                this.Hide();
                ShowmyM_J f = new ShowmyM_J(this,"Managers :", Dt);
                f.Show();
            }
            else
            {
                MsgShow mm = new MsgShow("No Emp For You!");
                mm.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_All_Jobs();
            if (Dt != null)
            {
                this.Hide();
                ShowmyM_J f = new ShowmyM_J(this, "Jobs :", Dt);
                f.Show();
            }
            else
            {
                MsgShow mm = new MsgShow("No Jobs For You!");
                mm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            promote f = new promote(this);
            f.Show();
        }
    }
}
