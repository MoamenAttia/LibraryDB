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
    public partial class editneeds : Form
    {
        Editmyprofile_emp ef;
        Controller cobj;
        int id;
        public editneeds(Editmyprofile_emp e,int i)
        {
            id = i;
            cobj = new Controller();
            ef = e;
            InitializeComponent();
        }

        private void editneeds_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ef.Show();
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
                cobj.Edit_Emp_Needs(id, textBox2.Text);
                MsgShow ms = new MsgShow("Done!");
                ms.ShowDialog();
            }
            else
            {
                MsgShow ms = new MsgShow("Enter Needs!");
                ms.ShowDialog();
            }
        }
    }
}
