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
    public partial class ManagerForm : Form
    {
        string nme;
        string id;
        Login_Form lf;
        Controller cobj;
        DataTable Dt;
        string Password;
        public ManagerForm(Login_Form l,string n,int i)
        {
            cobj = new Controller();
            nme = n;
            id = Convert.ToString(i);
            lf = l;
            InitializeComponent();
            Dt = cobj.Get_Employee_by_ID(Convert.ToInt32(id));
            Password = Dt.Rows[0].ItemArray[5].ToString();
            AddStory.Visible = AddBookBtn.Visible = AddMusic.Visible = AddCmp.Visible = false;
            if (Password == "SPR123") AddBookBtn.Visible = true;
            else if (Password == "SPR456") AddStory.Visible = true;
            else if (Password == "SPR789") AddMusic.Visible = true;
            else if (Password == "SPR101112") AddCmp.Visible = true;
        }

        private void GET_Stat_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetStatistics f = new GetStatistics(this, nme, id);
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Get_Emp_By_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetEmpBy f = new GetEmpBy(this,nme,id);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dt = cobj.Get_Employee_by_Manager(Convert.ToInt32(id));
            if (Dt != null)
            {
                this.Hide();
                Showmyemp f = new Showmyemp(this, null,Dt);
                f.Show();
            }
            else
            {
                MsgShow mm = new MsgShow("No Emp For You!");
                mm.ShowDialog();
            }
        }

        private void Get_Info_By_ID_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInfoofEmp f = new GetInfoofEmp(this,nme,id);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            name.Text = nme;
            id_num.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editmyprofile_emp f = new Editmyprofile_emp(this, null, null, nme, id);
            f.Show();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            Add_Book_Form Form = new Add_Book_Form();
            Form.Show();
        }

        private void AddMusic_Click(object sender, EventArgs e)
        {
            Add_Musical_Instrument_Form Form = new Add_Musical_Instrument_Form();
            Form.Show();
        }

        private void AddCmp_Click(object sender, EventArgs e)
        {
            Add_Computer_Form Form = new Add_Computer_Form();
            Form.Show();
        }

        private void AddStory_Click(object sender, EventArgs e)
        {
            Add_Story_Form Form = new Add_Story_Form();
            Form.Show();
        }
    }
}
