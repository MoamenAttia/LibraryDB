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
    public partial class Getempinfo_empmode : Form
    {
        GetInfoofEmp mf;
        getempinfochmode cf;
        EmployeeForm ef;
        DataTable Dt;
        Controller cobj;
        public Getempinfo_empmode(GetInfoofEmp m, getempinfochmode c,EmployeeForm e,DataTable d)
        {
            cobj = new Controller();
            Dt = d;
            mf = m;
            cf = c;
            ef = e;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Show();
            else if (mf != null)
                mf.Show();
            else if (ef != null)
                ef.Show();
        }

        private void Getempinfo_empmode_Load(object sender, EventArgs e)
        {
            label21.Text = Convert.ToString(Dt.Rows[0]["Fname"]) + " " +
                Convert.ToString(Dt.Rows[0]["Mname"]) + " " +
                Convert.ToString(Dt.Rows[0]["Lname"]);
            label10.Text = label21.Text;
            label11.Text = Convert.ToString(Dt.Rows[0]["Emp_ID"]);
            label12.Text = Convert.ToString(Dt.Rows[0]["Age"]);
            label13.Text = Convert.ToString(Dt.Rows[0]["Address"]);
            label14.Text = Convert.ToString(Dt.Rows[0]["Manager_ID"]);
            label16.Text = Convert.ToString(Dt.Rows[0]["Salary"]);
            label17.Text = Convert.ToString(Dt.Rows[0]["Job_Title"]);
            label18.Text = Convert.ToString(Dt.Rows[0]["Needs"]);
            if (Convert.ToString(Dt.Rows[0]["Employee_Image"]) !="")
            {
                var data = (Byte[])Dt.Rows[0]["Employee_Image"];
                var stream = new MemoryStream(data);
                PictureBox.Image = Image.FromStream(stream);
            }
            Dt = cobj.Get_Manager_Name(Convert.ToInt32(Dt.Rows[0]["Emp_ID"]));
            if (Dt != null)
                label15.Text = Convert.ToString(Dt.Rows[0]["Fname"]) + " " +
                    Convert.ToString(Dt.Rows[0]["Mname"]) + " " +
                    Convert.ToString(Dt.Rows[0]["Lname"]);
            else
            {
                label15.Text = "None";
                label14.Text = "None";
            }
        }

        private void dfs_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Close();
            else if (mf != null)
                mf.Close();
            else if (ef != null)
                ef.Close();
            Environment.Exit(1);

        }
    }
}
