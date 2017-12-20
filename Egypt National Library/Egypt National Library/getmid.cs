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
    public partial class getmid : Form
    {
        getempinfochmode cf;
        DataTable Dt;
        public getmid(getempinfochmode c,DataTable d)
        {
            Dt = d;
            cf = c;
            InitializeComponent();
        }

        private void getmid_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(Dt.Rows[0]["Manager_ID"]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }
    }
}
