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
    public partial class Music_Instrument_Details_Form : Form
    {
        Controller Controller_OBJ;
        string status;
        int userid;
        int InstrumentUserID;
        int InstrumentIDvar;
        string Instrument_Typevar;
        public Music_Instrument_Details_Form(string Music_InsName, string Music_InsPrice, string Music_InsSeciton, byte[] image,int UserID, string Status, int instrumentUserID, int Instrument_ID)
        {
            Controller_OBJ = new Controller();
            InitializeComponent();
            Music_Name.Text = Music_InsName;
            PriceLabel.Text = Music_InsPrice;
            SectionNameLabel.Text = Music_InsSeciton;
            MemoryStream ms = new MemoryStream(image);
            MusicIns_ImagePicturebox.Image = Image.FromStream(ms);
            MusicIns_ImagePicturebox.Refresh();
            userid = UserID;
            status = Status;
            InstrumentUserID = instrumentUserID;
            InstrumentIDvar = Instrument_ID;
            Instrument_Typevar = Music_InsSeciton;
        }

        private void Music_Instrument_Details_Form_Load(object sender, EventArgs e)
        {
            if (status == "Available" && InstrumentUserID == 0)
                
            {
                ReserveBtn.Enabled = true;
                ReserveBtn.Visible = true;
            }
            else
            {
                if (userid == InstrumentUserID)
                {
                    ReturnBtn.Enabled = true;
                    ReturnBtn.Visible = true;

                }
                else
                {
                    InUse.Visible = true;
                }


            }

        }


        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.UpdateInstrumentStatusAndInstrumentUserID(userid, InstrumentIDvar, Instrument_Typevar, 3, "InUse");
            if (Success == 1) MessageBox.Show("This Instrument has been reserved for you");

        }

        private void ReturnBtn_Click_1(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.UpdateInstrumentStatusAndInstrumentUserID_NULL(InstrumentIDvar, Instrument_Typevar, 3, "Available");
            if (Success == 1) MessageBox.Show("This Instrument has been unreserved");

        }

        private void RateBtn_Click(object sender, EventArgs e)
        {
         
            if (VeryPoor.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 2, 1);
                if (Success == 1) MessageBox.Show("You rated this as Verypoor");
            }
            else if (Poor.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 2, 2);
                if (Success == 1) MessageBox.Show("You rated this as poor");
            }
            else if (Good.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 2, 3);
                if (Success == 1) MessageBox.Show("You rated this as Good");
            }
            else if (VeryGood.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 2, 4);
                if (Success == 1) MessageBox.Show("You rated this as VeryGood");
            }
            else if (Excellent.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 2, 5);
                if (Success == 1) MessageBox.Show("You rated this as Excellent");
            }
        }
    }
}
