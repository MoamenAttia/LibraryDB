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
    public partial class getempinfochmode : Form
    {
        ChairmanForm cf;
        Controller cobj;
        DataTable Dt;
        public getempinfochmode(ChairmanForm c)
        {
            cobj = new Controller();
            cf = c;
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Close();
            Environment.Exit(1);

        }

        private void ff_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Name(Convert.ToInt32(textBox1.Text));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getfn f = new getfn(null, this,Dt);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Address(Convert.ToInt32(textBox1.Text));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getaddress f = new getaddress(null, this, Dt);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Salary(Convert.ToInt32(textBox1.Text));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getsalary f = new getsalary(null, this, Dt);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Age(Convert.ToInt32(textBox1.Text));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getage f = new getage(null, this, Dt);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Job(Convert.ToInt32(textBox1.Text));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getjob f = new getjob(null, this, Dt);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_Needs(Convert.ToInt32(textBox1.Text));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getneeds f = new getneeds(null, this, Dt);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Employee_by_ID(Convert.ToInt32(textBox1.Text));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getimage f = new getimage(null, this, Dt);
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Dt = cobj.Get_Employee_by_ID(Convert.ToInt32(textBox1.Text));
            if (Dt != null)
            {
                this.Hide();
                Getempinfo_empmode f = new Getempinfo_empmode(null, this, null, Dt);
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
            getid f = new getid(null, this,1);
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Emp_ManagerID(Convert.ToInt32(textBox1.Text));
            if (Dt == null||Convert.ToString(Dt.Rows[0]["Manager_ID"]) == "")
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getmid f = new getmid(this, Dt);
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Manager_Name(Convert.ToInt32(textBox1.Text));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found");
                mm.ShowDialog();
                return;
            }
            this.Hide();
            getmname f = new getmname(this,Dt);
            f.Show();
        }

        private void getempinfochmode_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out i))
            {
                textBox1.Text = "1";
                MsgShow ms = new MsgShow("Invalid ID!");
                ms.ShowDialog();
                return;
            }
        }
    }
}
