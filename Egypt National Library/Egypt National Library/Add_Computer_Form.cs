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
            if (Check_ImageValidation(PictureBox) == 0) return;
            int CmpID = Check_IDValidation(Cmp_ID.Text, "Cmp "); if (CmpID == 0) return;
            int Price = CheckPriceValidation(); if (Price == 0) return;
            int LibDepID = Check_IDValidation(Lib_Dep_ID.Text, "Lib Dep "); if (LibDepID == 0) return;
            MemoryStream ms = new MemoryStream();
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            byte[] image = ms.ToArray();
            Controller_OBJ.Add_New_Softawre(CmpID, Cmp_Sec_Name.Text, LibDepID, image);
        }

        private void Add_Software_Click(object sender, EventArgs e)
        {
            if (Check_ImageValidation(SoftwarePicturebox) == 0) return;
            int CmpID = Check_IDValidation(Cmp_ID.Text, "Cmp "); if (CmpID == 0) return;
            int LibDepID = Check_IDValidation(Lib_Dep_ID.Text, "Lib Dep "); if (LibDepID == 0) return;
            MemoryStream ms = new MemoryStream();
            SoftwarePicturebox.Image.Save(ms, SoftwarePicturebox.Image.RawFormat);
            byte[] image = ms.ToArray();
            Controller_OBJ.Add_New_Softawre(CmpID, Cmp_Sec_Name.Text, LibDepID, image);
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
 
        private int Check_IDValidation(string Text, string type)
        {
            int ID = 0;
            try { ID = int.Parse(Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid " + type + " ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (ID < 1)
            { MessageBox.Show("Please Sir , Add A valid " + type + " ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return ID;
        }
        private int CheckPriceValidation()
        {
            int price = 0;
            try { price = int.Parse(Cmp_Price.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (price < 1)
            { MessageBox.Show("Please Sir , Add A valid Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return price;
        }

        private int Check_ImageValidation(PictureBox PictureBox)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
                byte[] image = ms.ToArray();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Please Sir Insert The Image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            return 1;
        }
    }
}
