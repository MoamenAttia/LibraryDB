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
    public partial class Login_Form : Form
    {
        Controller Controller_OBJ;
        public Login_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIN_Button_Click(object sender, EventArgs e)
        {
            int ID = Check_IDValidation(User_ID_Textbox.Text, "User");
            if (ID == 0) return;
            string Password = Password_Textbox.Text;
            DataTable dt = Controller_OBJ.GetUserByID(ID);
            if (dt == null) { MessageBox.Show("The Id You have Entered does not match any ID in the library", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Password.Contains("User"))
            {
                if (Password == dt.Rows[0].ItemArray[5].ToString())
                {
                    MessageBox.Show("Welcome " + dt.Rows[0].ItemArray[0].ToString() , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User_Form Form = new User_Form(dt.Rows[0].ItemArray[0].ToString() + " " + dt.Rows[0].ItemArray[1].ToString() + " " + dt.Rows[0].ItemArray[2].ToString(), "Rate : " + dt.Rows[0].ItemArray[3].ToString(), (byte[])dt.Rows[0].ItemArray[6], ID);
                    Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            dt = Controller_OBJ.Get_Employee_by_ID_forlog(ID);
            if (Password.Contains("Man"))
            {
                if (Password ==  dt.Rows[0]["Password"].ToString())
                {
                    MessageBox.Show("Welcome " + dt.Rows[0].ItemArray[0].ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChairmanForm Form = new ChairmanForm(this, dt.Rows[0].ItemArray[0].ToString()+" "+ dt.Rows[0].ItemArray[1].ToString()+" "+ dt.Rows[0].ItemArray[2].ToString());
                    Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (Password.Contains("SPR"))
            {
                if (Password == dt.Rows[0]["Password"].ToString())
                {
                    MessageBox.Show("Welcome " + dt.Rows[0].ItemArray[0].ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManagerForm Form = new ManagerForm(this, dt.Rows[0].ItemArray[0].ToString() + " " + dt.Rows[0].ItemArray[1].ToString() + " " + dt.Rows[0].ItemArray[2].ToString(), ID);
                    Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (Password.Contains("EMP"))
            {
                if (Password == dt.Rows[0]["Password"].ToString())
                {
                    MessageBox.Show("Welcome " + dt.Rows[0].ItemArray[0].ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmployeeForm Form = new EmployeeForm(this, dt.Rows[0].ItemArray[0].ToString() + " " + dt.Rows[0].ItemArray[1].ToString() + " " + dt.Rows[0].ItemArray[2].ToString(), ID);
                    Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private int Check_IDValidation(string Text, string type)
        {
            int ID = 0;
            try { ID = int.Parse(Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid " + type + " ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (ID < 1)
            { MessageBox.Show("Please Sir , Add A valid " + type + " ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return ID;
        }
    }
}
