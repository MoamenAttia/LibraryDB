using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Egypt_National_Library
{
    public partial class Add_Musical_Instrument_Form : Form
    {
        Controller Controller_OBJ = new Controller ();
        public Add_Musical_Instrument_Form()
        {
            InitializeComponent();
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
            MemoryStream ms = new MemoryStream();
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            byte[] image = ms.ToArray();


            //int Success = Controller_OBJ.Update_Instrument_Image (image,Convert.ToInt32(Instrument_ID.Text), Convert.ToInt32(Music_Lib_Dep_ID.Text),Instrument_Type.Text);
            //if (Success == 0)
            //    MessageBox.Show("Failed To Update Image", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Image is Updated Successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);

         
            int Instrument_id = Check_IDValidation(Instrument_ID.Text, "Instrument"); int price = CheckPriceValidation();
            int Music_Lib_Dep_id = Check_IDValidation(Music_Lib_Dep_ID.Text, "Lib Dep");
           

            int Success = Controller_OBJ.Add_Instrument(Convert.ToInt32(Instrument_ID.Text), Instrument_Name.Text
                ,Convert.ToInt32(Price.Text), Instrument_Type.Text, Convert.ToInt32(Music_Lib_Dep_ID.Text), image);
            if (Success == 0)
                MessageBox.Show("Failed To Add A new Instrument", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("A New Instrument has been added Successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            try { price = int.Parse(Price.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (price < 1)
            { MessageBox.Show("Please Sir , Add A valid Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return price;
        }

        private void Instrument_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Music_Lib_Dep_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Instrument_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Instrument_Name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
