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
    public partial class Showmyemp : Form
    {
        ManagerForm mf;
        ChairmanForm cf;
        DataTable Dt;
        public Showmyemp(ManagerForm m,ChairmanForm c,DataTable d)
        {
            Dt = d;
            mf = m;
            cf = c;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Show();
            else if (mf != null)
                mf.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (cf != null)
                cf.Close();
            else if (mf != null)
                mf.Close();
            Environment.Exit(1);

        }

        private void Showmyemp_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Dt;
            dataGridView1.Refresh();
            MsgShow m = new MsgShow("Done");
            m.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
