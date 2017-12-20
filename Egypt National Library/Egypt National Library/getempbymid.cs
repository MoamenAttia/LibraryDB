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
    public partial class getempbymid : Form
    {
        GetEmpBy mf;
        getempbychmode cf;
        Controller cobj;
        DataTable Dt;
        public getempbymid(GetEmpBy m, getempbychmode c)
        {
            cobj = new Controller();
            mf = m;
            cf = c;
            InitializeComponent();
        }

        private void getempbymid_Load(object sender, EventArgs e)
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
                cf.Close ();
            else if (mf != null)
                mf.Close();
        }

        private void dfs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            int i;
            if (!int.TryParse(textBox1.Text, out i))
            {
                MsgShow a = new MsgShow("Enter a Valid Manager ID!");
                a.ShowDialog();
                return;
            }
            Dt = cobj.Get_Employee_by_Manager(i);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
