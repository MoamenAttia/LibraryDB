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
    public partial class Add_User_Form : Form
    {
        Controller Controller_OBJ;
        public Add_User_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }

        private void Add_User_Form_Load(object sender, EventArgs e){ }

        private void Browse_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialogobj = new OpenFileDialog();
            OpenFileDialogobj.Filter = "Images | *.jpg; *.png";
            if (OpenFileDialogobj.ShowDialog() == DialogResult.OK)
                PictureBox.Image = Image.FromFile(OpenFileDialogobj.FileName);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            byte[] image = ms.ToArray();
            int Success = Controller_OBJ.UpdateUserImage(image, int.Parse(User_ID.Text));
        }
    }
}
