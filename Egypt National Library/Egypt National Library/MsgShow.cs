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
    public partial class MsgShow : Form
    {
        string text;
        public MsgShow(string t)
        {
            text = t;
            InitializeComponent();
        }

        private void MsgShow_Load(object sender, EventArgs e)
        {
            label3.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
