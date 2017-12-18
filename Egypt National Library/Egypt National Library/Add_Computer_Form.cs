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
    public partial class Add_Computer_Form : Form
    {
        Controller Controller_OBJ;
        public Add_Computer_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }

        private void Add_Computer_Form_Load(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialogobj = new OpenFileDialog();
            OpenFileDialogobj.Filter = "Images | *.jpg; *.png; *.jpeg";
            if (OpenFileDialogobj.ShowDialog() == DialogResult.OK)
                PictureBox.Image = Image.FromFile(OpenFileDialogobj.FileName);
        }

        private void Add_Computer_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            byte[] image = ms.ToArray();
            Controller_OBJ.UpdateComputerImage(int.Parse(Cmp_ID.Text), int.Parse(Lib_Dep_ID.Text), Cmp_Sec_Name.Text, image);
        }

        private void Add_Software_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            SoftwarePicturebox.Image.Save(ms, SoftwarePicturebox.Image.RawFormat);
            byte[] image = ms.ToArray();

            Controller_OBJ.UpdateSoftwareImage(image, Software.Text, int.Parse(Lib_Dep_ID.Text), Cmp_Sec_Name.Text, int.Parse(Cmp_ID.Text));
        }

        private void BrowseSoftwareImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialogobj = new OpenFileDialog();
            OpenFileDialogobj.Filter = "Images | *.jpg; *.png; *.jpeg";
            if (OpenFileDialogobj.ShowDialog() == DialogResult.OK)
                SoftwarePicturebox.Image = Image.FromFile(OpenFileDialogobj.FileName);
        }

        private void SoftwarePicturebox_Click(object sender, EventArgs e)
        {

        }
    }
}
