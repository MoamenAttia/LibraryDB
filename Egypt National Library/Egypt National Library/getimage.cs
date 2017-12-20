using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_National_Library
{
    public partial class getimage : Form
    {
        GetInfoofEmp mf;
        getempinfochmode cf;
        DataTable Dt;
        public getimage(GetInfoofEmp m, getempinfochmode c,DataTable d)
        {
            Dt = d;
            mf = m;
            cf = c;
            InitializeComponent();
        }

        private void getimage_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Dt.Rows[0]["Employee_Image"]) != "")
            {
                var data = (Byte[])Dt.Rows[0]["Employee_Image"];
                var stream = new MemoryStream(data);
                PictureBox.Image = Image.FromStream(stream);
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
        }
    }
}
