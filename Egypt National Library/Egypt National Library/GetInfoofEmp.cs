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
    public partial class GetInfoofEmp : Form
    {
        ManagerForm mf;
        DataTable Dt;
        Controller cobj;
        string nme;
        string id1;
        public GetInfoofEmp(ManagerForm m,string n,string i)
        {
            nme = n;
            id1 = i;
            cobj = new Controller();
            mf = m;
            InitializeComponent();
        }

        private void GetInfoofEmp_Load(object sender, EventArgs e)
        {

        }

        private void ff_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Namemn(Convert.ToInt32(textBox1.Text),Convert.ToInt32(id1));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getfn f = new getfn(this, null, Dt);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Addressmn(Convert.ToInt32(textBox1.Text), Convert.ToInt32(id1));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getaddress f = new getaddress(this, null, Dt);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Salarymn(Convert.ToInt32(textBox1.Text), Convert.ToInt32(id1));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getsalary f = new getsalary(this, null, Dt);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                MsgShow mm = new MsgShow("It is Private!");
                mm.ShowDialog();
                return;
            }
            Dt = cobj.Get_Emp_Agemn(Convert.ToInt32(textBox1.Text), Convert.ToInt32(id1));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getage f = new getage(this, null, Dt);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Jobmn(Convert.ToInt32(textBox1.Text), Convert.ToInt32(id1));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getjob f = new getjob(this, null, Dt);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Needsmn(Convert.ToInt32(textBox1.Text), Convert.ToInt32(id1));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getneeds f = new getneeds(this, null, Dt);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Imagemn(Convert.ToInt32(textBox1.Text), Convert.ToInt32(id1));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getimage f = new getimage(this, null, Dt);
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                MsgShow mm = new MsgShow("It is Private!");
                mm.ShowDialog();
                return;
            }
            Dt = cobj.Get_Employee_by_IDmn(Convert.ToInt32(textBox1.Text), Convert.ToInt32(id1));
            if (Dt != null)
            {
                this.Hide();
                Getempinfo_empmode f = new Getempinfo_empmode(this, null, null,Dt);
                f.Show();
            }
            else
            {
                MsgShow ms = new MsgShow("Invalid ID!");
                ms.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            getid f = new getid(this, null, Convert.ToInt32(id1));
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            mf.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            mf.Close();
            Environment.Exit(1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out i))
            {
                textBox1.Text = "2";
                MsgShow ms = new MsgShow("Invalid ID!");
                ms.ShowDialog();
                return;
            } 
        }
    }
}
