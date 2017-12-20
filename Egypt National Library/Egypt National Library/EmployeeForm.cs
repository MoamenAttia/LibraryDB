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
    public partial class EmployeeForm : Form
    {
        string nme;
        string id;
        Login_Form lf;
        Controller cobj;
        DataTable Dt;
        public EmployeeForm(Login_Form l, string n, int i)
        {
            cobj = new Controller();
            nme = n;
            id = Convert.ToString(i);
            lf = l;
            InitializeComponent();
        }

        private void Get_Emp_By_BT_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Employee_by_ID(Convert.ToInt32(id));
            this.Hide();
            if (Dt != null)
            {
                Getempinfo_empmode f = new Getempinfo_empmode(null, null, this, Dt);
                f.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editmyprofile_emp f = new Editmyprofile_emp(null, null, this, nme, id);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            lf.Close();
            Environment.Exit(1);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            label1.Text = nme;
            label4.Text = id;
        }
    }
}
