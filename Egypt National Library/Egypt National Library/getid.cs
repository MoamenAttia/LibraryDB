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
    public partial class getid : Form
    {
        GetInfoofEmp mf;
        getempinfochmode cf;
        DataTable Dt;
        Controller cobj;
        int id;
        public getid(GetInfoofEmp m, getempinfochmode c,int i)
        {
            id = i;
            cobj = new Controller();
            mf = m;
            cf = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Show();
            else if (mf != null)
                mf.Show();
        }

        private void getid_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Close();
            else if (mf != null)
                mf.Close();
        }

        private void dfs_Click(object sender, EventArgs e)
        {
            label6.Text = "id";
            int i;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || int.TryParse(textBox1.Text, out i) || int.TryParse(textBox2.Text, out i) || int.TryParse(textBox3.Text, out i))
            {
                MsgShow a = new MsgShow("Enter a Valid Name !");
                a.ShowDialog();
                return;
            }
            if (cf != null)
                Dt = cobj.Get_Emp_ID_byname(textBox1.Text, textBox2.Text, textBox3.Text);
            else if (mf != null)
                Dt = cobj.Get_Emp_ID_bynamemn(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(id));
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found!");
                mm.ShowDialog();
                return;
            }
            label6.Text = Convert.ToString(Dt.Rows[0]["Emp_ID"]);
            MsgShow m = new MsgShow("Done");
            m.ShowDialog();
        }
    }
}
