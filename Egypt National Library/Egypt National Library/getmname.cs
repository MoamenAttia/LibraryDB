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
    public partial class getmname : Form
    {
        getempinfochmode cf;
        DataTable Dt;
        public getmname(getempinfochmode c,DataTable d)
        {
            Dt = d;
            cf = c;
            InitializeComponent();
        }

        private void getmname_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(Dt.Rows[0]["Fname"]) + " " +
                Convert.ToString(Dt.Rows[0]["Mname"]) + " " +
                Convert.ToString(Dt.Rows[0]["Lname"]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }
    }
}
