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
    public partial class Add_Story_Form : Form
    {
        Controller Controller_OBJ;
        public Add_Story_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }

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
            int Story_id = Check_IDValidation(Story_ID, "Story_ID");    int price = CheckPriceValidation();
            int Story_dep = Check_IDValidation(Story_Dep, "Story_Dep");
            if (Check_ImageValidation() == 0) return;
            MemoryStream ms = new MemoryStream();
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            byte[] image = ms.ToArray();
      
            int Success = Controller_OBJ.Add_Story(Story_id, Story_Name.Text, price, Story_Sec_Name.Text, Story_dep, image);
            if (Success == 0)
                MessageBox.Show("Failed To Add A New Story", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("A New Story has been added Successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int Check_IDValidation(Control Textbox, string type)
        {
            int ID = 0;
            try { ID = int.Parse(Textbox.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid " + type + " ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (ID < 1)
            { MessageBox.Show("Please Sir , Add A valid " + type + " ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return ID;
        }
        private int CheckPriceValidation()
        {
            int price = 0;
            try { price = int.Parse(Price.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (price < 1)
            { MessageBox.Show("Please Sir , Add A valid Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return price;
        }

        private void Add_Story_Form_Load(object sender, EventArgs e)
        {

        }
        private int Check_ImageValidation()
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
