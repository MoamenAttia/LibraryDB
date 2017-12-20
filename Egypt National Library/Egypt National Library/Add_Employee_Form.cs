using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_National_Library
{
    public partial class Add_Employee_Form : Form
    {
        Controller Controller_OBJ;
        ChairmanForm cf;
        public Add_Employee_Form(ChairmanForm c)
        {
            cf = c;
            InitializeComponent();
            Controller_OBJ = new Controller();
        }
        
        private void Browse_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialogobj = new OpenFileDialog();
            OpenFileDialogobj.Filter = "Images | *.jpg; *.png";
            if (OpenFileDialogobj.ShowDialog() == DialogResult.OK)
                PictureBox.Image = Image.FromFile(OpenFileDialogobj.FileName);
        }

        private void Add_Employee_Form_Load(object sender, EventArgs e)
        {
            label11.Hide();
            textBox11.Hide();
            DataTable Dt;
            int i = 1;
            do
            {
                Dt = Controller_OBJ.Get_Employee_by_ID_forlog(i);
                i++;
            } while (Dt != null);
            Emp_ID.Text = Convert.ToString(i-1);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            cf.Show();
            this.Close();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            byte[] image;
            if (PictureBox.Image == null)
            {
                MsgShow msg = new MsgShow("Wrong Image!");
                msg.ShowDialog();
                return;
            }
                PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
                image = ms.ToArray();
            if (radioButton2.Checked && textBox11.Text=="")
            {
                MsgShow msg = new MsgShow("Wrong Emp for Manager ID!");
                msg.ShowDialog();
                return;
            }
            int i;
            string fn;
            if (Empfn.Text == "" || int.TryParse(Empfn.Text, out i))
            {
                MsgShow msg = new MsgShow("Wrong Fname!");
                msg.ShowDialog();
                return;
            }
            else
                fn = Empfn.Text;

            string mn;
            if (EmpMn.Text == "" || int.TryParse(EmpMn.Text, out i))
            {
                MsgShow msg = new MsgShow("Wrong Mname!");
                msg.ShowDialog();
                return;
            }
            else
                mn = EmpMn.Text;
            string ln;
            if (Empln.Text == "" || int.TryParse(Empln.Text, out i))
            {
                MsgShow msg = new MsgShow("Wrong Lname!");
                msg.ShowDialog();
                return;
            }
            else
                ln = Empln.Text;
            int s;
            if (Salary.Text == "" || !int.TryParse(Salary.Text, out s))
            {
                MsgShow msg = new MsgShow("Wrong Salary!");
                msg.ShowDialog();
                return;
            }
            int eid;
            if (Emp_ID.Text == "" || !int.TryParse(Emp_ID.Text, out eid))
            {
                MsgShow msg = new MsgShow("Wrong EID!");
                msg.ShowDialog();
                return;
            }
            string Pas;
            if (Pass.Text == "")
            {
                MsgShow msg = new MsgShow("Wrong Password!");
                msg.ShowDialog();
                return;
            }
            else
                Pas = Pass.Text;
            int age;
            if (Age.Text == "" || !int.TryParse(Age.Text, out age))
            {
                MsgShow msg = new MsgShow("Wrong Age!");
                msg.ShowDialog();
                return;
            }
            string ad;
            if (Addres.Text == "")
            {
                MsgShow msg = new MsgShow("Wrong Address!");
                msg.ShowDialog();
                return;
            }
            else
                ad = Addres.Text;
            string j;
            if (radioButton1.Checked)
            {
                j = " Employee";
            }
            else if (radioButton2.Checked)
            {
                j = " Super Visor";
            }
            else
            {
                MsgShow msg = new MsgShow("Wrong Choice!");
                msg.ShowDialog();
                return;
            }
            string j_t;
            if (radioButton2.Checked)
            {
                DataTable temp = Controller_OBJ.Get_Emp_Job(Convert.ToInt32(textBox11.Text));
                if (temp == null || Convert.ToString(temp.Rows[0]["Job_Title"]) == "")
                {
                    MsgShow msg = new MsgShow("Invalid Emp Manager ID!");
                    msg.ShowDialog();
                    return;
                }
                j_t = Convert.ToString(temp.Rows[0]["Job_Title"]);
                if (!j_t.Contains(comboBox1.Text))
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
            }
            if (comboBox1.Text == "Book Dep.")
            {
                DataTable iii = Controller_OBJ.Count_Employees_under_Job("Book Dep. Employee");
                double k = Convert.ToDouble(iii.Rows[0]["N_Of_Emp"]);
                if (radioButton2.Checked && k <= 1)
                {
                    MsgShow msg = new MsgShow("Cannot add a new Manager to this dep (1 Emp)!");
                    msg.ShowDialog();
                    return;
                }
                j = "Book Dep." + j;
            }
            else if (comboBox1.Text == "Story Dep.")
            {
                DataTable iii = Controller_OBJ.Count_Employees_under_Job("Story Dep. Employee");
                double k = Convert.ToDouble(iii.Rows[0]["N_Of_Emp"]);
                if (radioButton2.Checked && k <= 1)
                {
                    MsgShow msg = new MsgShow("Cannot add a new Manager to this dep (1 Emp)!");
                    msg.ShowDialog();
                    return;
                }
                j = "Story Dep." + j;
            }
            else if (comboBox1.Text == "Music Dep.")
            {
                DataTable iii = Controller_OBJ.Count_Employees_under_Job("Music Dep. Employee");
                double k = Convert.ToDouble(iii.Rows[0]["N_Of_Emp"]);
                if (radioButton2.Checked &&  k<= 1)
                {
                    MsgShow msg = new MsgShow("Cannot add a new Manager to this dep (1 Emp)!");
                    msg.ShowDialog();
                    return;
                }
                j = "Music Dep." + j;
            }
            else if (comboBox1.Text == "Computer Dep.")
            {
                DataTable iii = Controller_OBJ.Count_Employees_under_Job("Computer Dep. Employee");
                double k = Convert.ToDouble(iii.Rows[0]["N_Of_Emp"]);
                if (radioButton2.Checked && k <= 1)
                {
                    MsgShow msg = new MsgShow("Cannot add a new Manager to this dep (1 Emp)!");
                    msg.ShowDialog();
                    return;
                }
                j = "Computer Dep." + j;
            }
            else
            {
                MsgShow msg = new MsgShow("Combobox Error!");
                msg.ShowDialog();
                return;
            }
            int mid;
            if (MID.Text == "" || !int.TryParse(MID.Text, out mid))
            {
                MsgShow msg = new MsgShow("Wrong MID!");
                msg.ShowDialog();
                return;
            }

            
            int Success = Controller_OBJ.Add_Employee(fn, mn, ln, s, eid, Pas, age
                , j, "No Needs", ad, mid, image);
            if (radioButton2.Checked)
            {
                Controller_OBJ.Edit_Emp_Manager(Convert.ToInt32(textBox11.Text), eid);
            }
            if (Success == 0)
            {
                MessageBox.Show("Failed To Add A new Employee .Make sure You enter The Right ID and MID");
                Return_Click(sender, e);
            }
            else
                MessageBox.Show("A New Employee has been added Successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label11.Show();
                textBox11.Show();
                comboBox1.Enabled = true;
                MID.Enabled = false;
                MID.Text = "1";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label11.Hide();
                textBox11.Hide();
                comboBox1.Enabled = true;
                MID.Enabled = true;
                MID.Text = "";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Close();
        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (textBox11.Text != "")
            {
                if (!int.TryParse(textBox11.Text, out i))
                {
                    MsgShow mm = new MsgShow("Invalid EMID!");
                    mm.ShowDialog();
                    textBox11.Text = "";
                    return;
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
