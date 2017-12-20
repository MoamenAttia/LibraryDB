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
    public partial class getempbyaddress : Form
    {
        GetEmpBy mf;
        getempbychmode cf;
        Controller cobj;
        DataTable Dt;
        int id;
        public getempbyaddress(GetEmpBy m, getempbychmode c,int i)
        {
            id = i;
            cobj = new Controller();
            mf = m;
            cf = c;
            InitializeComponent();
        }

        private void getempbyaddress_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Show();
            else if (mf != null)
                mf.Show();
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
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            int i;
            if (textBox1.Text == "")
            {
                MsgShow a = new MsgShow("Enter a Valid Address!");
                a.ShowDialog();
                return;
            }
            if (cf != null)
                Dt = cobj.Get_Employee_by_Address(textBox1.Text);
            else if (mf !=null)
                Dt = cobj.Get_Employee_by_Addressmn(textBox1.Text,id);
            if (Dt == null)
            {
                MsgShow mm = new MsgShow("Not Found!");
                mm.ShowDialog();
                return;
            }
            dataGridView1.DataSource = Dt;
            dataGridView1.Refresh();
            MsgShow m = new MsgShow("Done");
            m.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
