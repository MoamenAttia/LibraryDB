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
    public partial class ShowmyM_J : Form
    {
        ChairmanForm cf;
        DataTable Dt;
        string Title;
        public ShowmyM_J(ChairmanForm c, string t, DataTable d)
        {
            Dt = d;
            Title = t;
            cf = c;
            InitializeComponent();
        }

        private void ShowmyM_J_Load(object sender, EventArgs e)
        {
            label3.Text = label3.Text + Title + "!";
            dataGridView1.DataSource = Dt;
            dataGridView1.Refresh();
            MsgShow m = new MsgShow("Done");
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Close();
            Environment.Exit(1);
        }
    }
}
