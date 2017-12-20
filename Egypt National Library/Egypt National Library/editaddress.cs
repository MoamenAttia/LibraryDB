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
    public partial class editaddress : Form
    {
        Editmyprofile_emp ef;
        Controller Controller_OBJ;
        int id;
        public editaddress(Editmyprofile_emp e,int i)
        {
            id = i;
            Controller_OBJ = new Controller();
            ef = e;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ef.Show();
        }

        private void editaddress_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ef.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Controller_OBJ.Edit_Emp_Address(id, textBox2.Text);
                MsgShow ms = new MsgShow("Done!");
                ms.ShowDialog();
            }
            else
            {
                MsgShow ms = new MsgShow("Enter Address!");
                ms.ShowDialog();
            }
        }
    }
}
