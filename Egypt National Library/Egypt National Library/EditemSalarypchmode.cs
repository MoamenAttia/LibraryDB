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
    public partial class EditemSalarypchmode : Form
    {
        ChairmanForm cf;
        Controller cobj;
        public EditemSalarypchmode(ChairmanForm c)
        {
            cobj = new Controller();
            cf = c;
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Close();
            Environment.Exit(1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }

        private void EditemSalarypchmode_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text != "")
            {
                if (!int.TryParse(textBox1.Text, out i))
                {
                    MsgShow mm = new MsgShow("Invalid ID");
                    mm.ShowDialog();
                    textBox1.Text = "";
                    return;
                }
            }
            if (textBox1.Text !="")
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (textBox2.Text != "")
            {
                if (int.TryParse(textBox2.Text, out i))
                {
                    MsgShow mm = new MsgShow("Invalid Job");
                    mm.ShowDialog();
                    textBox2.Text = "";
                    return;
                }
            }
            if (textBox2.Text != "")
            {
                textBox1.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (textBox3.Text != "")
            {
                if (!int.TryParse(textBox3.Text, out i))
                {
                    MsgShow mm = new MsgShow("Invalid Age");
                    mm.ShowDialog();
                    textBox3.Text = "";
                    return;
                }
            }
            if (textBox3.Text != "")
            {
                textBox2.Enabled = false;
                textBox1.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void salt_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (salt.Text != "")
            {
                if (!int.TryParse(salt.Text, out i))
                {
                    MsgShow mm = new MsgShow("Invalid Salary");
                    mm.ShowDialog();
                    salt.Text = "";
                    return;
                }
            }
        }

        private void Pas_Click(object sender, EventArgs e)
        {
            if (salt.Text =="")
            {
                MsgShow mm = new MsgShow("Invalid Salary");
                mm.ShowDialog();
                return;
            }
            if (textBox1.Text != "")
            {
                cobj.Edit_Emp_Sal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(salt.Text));
                MsgShow mm = new MsgShow("Done");
                mm.ShowDialog();
                return;
            }
            else if (textBox2.Text != "")
            {
                cobj.Set_Salary_for_Job(textBox2.Text, Convert.ToInt32(salt.Text));
                MsgShow mm = new MsgShow("Done");
                mm.ShowDialog();
                return;
            }
            else if (textBox3.Text != "")
            {
                cobj.Set_Salary_for_Age(Convert.ToInt32(textBox3.Text), Convert.ToInt32(salt.Text));
                MsgShow mm = new MsgShow("Done");
                mm.ShowDialog();
                return;
            }
            else
            {
                MsgShow mm = new MsgShow("Invalid Method");
                mm.ShowDialog();
                return;
            }
        }
    }
}
