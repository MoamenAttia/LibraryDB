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
    public partial class getempbysal : Form
    {
        GetEmpBy mf;
        getempbychmode cf;
        Controller cobj;
        DataTable Dt;
        int id;
        public getempbysal(GetEmpBy m, getempbychmode c,int i)
        {
            id = i;
            cobj = new Controller();
            mf = m;
            cf = c;
            InitializeComponent();
        }

        private void getempbysal_Load(object sender, EventArgs e)
        {

        }

        private void dfs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            int i;
            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out i))
            {
                MsgShow a = new MsgShow("Enter a Valid Salary!");
                a.ShowDialog();
                return;
            }
            if (radioButton1.Checked)
            {
                if (cf != null)
                    Dt = cobj.Get_Employee_equal_sal(i);
                else if (mf !=null)
                    Dt = cobj.Get_Employee_equal_salmn(i,id);
            }
            else if (radioButton2.Checked)
            {
                if (cf != null)
                    Dt = cobj.Get_Employee_above_sal(i);
                else if (mf != null)
                    Dt = cobj.Get_Employee_above_salmn(i,id);
            }
            else if (radioButton3.Checked)
            {
                if (cf != null)
                    Dt = cobj.Get_Employee_below_sal(i);
                else if (mf != null)
                    Dt = cobj.Get_Employee_below_salmn(i,id);
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
