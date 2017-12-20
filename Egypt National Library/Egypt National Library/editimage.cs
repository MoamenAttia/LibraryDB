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
    public partial class editimage : Form
    {
        Editmyprofile_emp ef;
        int id;
        Controller cobj;
        public editimage(Editmyprofile_emp e,int i)
        {
            id = i;
            cobj = new Controller();
            ef = e;
            InitializeComponent();
        }

        private void editimage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ef.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ef.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialogobj = new OpenFileDialog();
            OpenFileDialogobj.Filter = "Images | *.jpg; *.png";
            if (OpenFileDialogobj.ShowDialog() == DialogResult.OK)
                PictureBox.Image = Image.FromFile(OpenFileDialogobj.FileName);
            else
                return;
            MemoryStream ms = new MemoryStream();
            byte[] image;
            if (PictureBox.Image == null)
            {
                MsgShow msg = new MsgShow("Wrong Image!");
                msg.ShowDialog();
                return;
            }
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            image = ms.ToArray();
            cobj.Edit_Emp_Image(id, image);
            MsgShow mm = new MsgShow("Done!");
            mm.ShowDialog();
        }
    }
}
