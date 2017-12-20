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
    public partial class promote : Form
    {
        ChairmanForm cf;
        Controller cobj;
        DataTable Dt;
        public promote(ChairmanForm c)
        {
            cobj = new Controller();
            cf = c;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Close();
            Environment.Exit(1);
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
        }

        private void Pas_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MsgShow mm = new MsgShow("No ID!");
                mm.ShowDialog();
                return;
            }
            if (textBox3.Text == "")
            {
                MsgShow msg = new MsgShow("Wrong Emp for Manager ID!");
                msg.ShowDialog();
                return;
            }
            if (textBox1.Text == textBox3.Text)
            {
                MsgShow msg = new MsgShow("Error 1 = 2!");
                msg.ShowDialog();
                return;
            }
            if (checkBox1.Checked && textBox2.Text == "")
            {
                MsgShow mm = new MsgShow("No new Salary!");
                mm.ShowDialog();
                return;
            }
            Dt = cobj.Get_Emp_Job(Convert.ToInt32(textBox1.Text));
            string j_t;
            DataTable temp = cobj.Get_Emp_Job(Convert.ToInt32(textBox3.Text));
            if (temp == null || Convert.ToString(temp.Rows[0]["Job_Title"]) == "")
            {
                MsgShow msg = new MsgShow("Invalid Emp Manager ID!");
                msg.ShowDialog();
                return;
            }
            j_t = Convert.ToString(temp.Rows[0]["Job_Title"]);
            string jjj = Dt.Rows[0]["Job_Title"].ToString();
            jjj.Remove(4, 10);
            if (!j_t.Contains(jjj))
            {
                MsgShow msg = new MsgShow("Emp Manager ID doesnot Match!");
                msg.ShowDialog();
                return;
            }
            if (j_t.Contains("Super Visor"))
            {
                MsgShow msg = new MsgShow("Emp Manager ID Is for a Manager!");
                msg.ShowDialog();
                return;
            }
            DataTable Da = cobj.Count_Employees_under_Job(j_t);
            double k = Convert.ToDouble(Da.Rows[0]["N_Of_Emp"]); ;
            if (k <=1)
            {
                MsgShow msg = new MsgShow("Cannot add a new Manager to this dep (1 Emp)!");
                msg.ShowDialog();
                return;
            }

            if (Dt == null || Convert.ToString(Dt.Rows[0]["Job_Title"]) == "")
            {
                MsgShow mm = new MsgShow("Invalid ID!");
                mm.ShowDialog();
                return;
            }
            if (Convert.ToString(Dt.Rows[0]["Job_Title"]) == "General Manager")
            {
                MsgShow mm = new MsgShow("Cannot Promote The Chairman!");
                mm.ShowDialog();
                return;
            }
            if (Convert.ToString(Dt.Rows[0]["Job_Title"]).Contains("Super Visor"))
            {
                MsgShow mm = new MsgShow("Cannot Promote A Manager!");
                mm.ShowDialog();
                return;
            }
            if (Convert.ToString(Dt.Rows[0]["Job_Title"]).Contains("Book"))
            {
                cobj.Edit_Emp_Job(Convert.ToInt32(textBox1.Text), "Book Dep. Super Visor");
                if (checkBox1.Checked)
                {
                    cobj.Edit_Emp_Sal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                }
                MsgShow mm = new MsgShow("Done!");
                mm.ShowDialog();
                
            }
            else if (Convert.ToString(Dt.Rows[0]["Job_Title"]).Contains("Music"))
            {
                cobj.Edit_Emp_Job(Convert.ToInt32(textBox1.Text), "Music Dep. Super Visor");
                if (checkBox1.Checked)
                {
                    cobj.Edit_Emp_Sal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                }
                MsgShow mm = new MsgShow("Done!");
                mm.ShowDialog();
                
            }
            else if (Convert.ToString(Dt.Rows[0]["Job_Title"]).Contains("Computer"))
            {
                cobj.Edit_Emp_Job(Convert.ToInt32(textBox1.Text), "Computer Dep. Super Visor");
                if (checkBox1.Checked)
                {
                    cobj.Edit_Emp_Sal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                }
                MsgShow mm = new MsgShow("Done!");
                mm.ShowDialog();
                
            }
           else if (Convert.ToString(Dt.Rows[0]["Job_Title"]).Contains("Story"))
            {
                cobj.Edit_Emp_Job(Convert.ToInt32(textBox1.Text), "Story Dep. Super Visor");
                if (checkBox1.Checked)
                {
                    cobj.Edit_Emp_Sal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                }
                MsgShow mm = new MsgShow("Done!");
                mm.ShowDialog();
            }
            Dt = cobj.Get_Employee_by_ID_forlog(Convert.ToInt32(textBox1.Text));
            string Oldpass = Dt.Rows[0]["Password"].ToString();
            string newpass = Oldpass;
            newpass.Remove(0, 1);
            newpass.Replace("EMP", "SPR");
            cobj.Edit_Emp_Pass(Convert.ToInt32(textBox1.Text), newpass);
            cobj.Edit_Emp_Manager(Convert.ToInt32(textBox1.Text), 1);
            cobj.Edit_Emp_Manager(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox1.Text));

        }

        private void promote_Load(object sender, EventArgs e)
        {
            label2.Hide();
            textBox2.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (textBox2.Text != "")
            {
                if (!int.TryParse(textBox2.Text, out i))
                {
                    MsgShow mm = new MsgShow("Invalid ID");
                    mm.ShowDialog();
                    textBox2.Text = "";
                    return;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Show();
                textBox2.Show();
            }
            else
            {
                label2.Hide();
                textBox2.Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (textBox3.Text != "")
            {
                if (!int.TryParse(textBox3.Text, out i))
                {
                    MsgShow mm = new MsgShow("Invalid EMID!");
                    mm.ShowDialog();
                    textBox3.Text = "";
                    return;
                }
            }
        }
    }
}
