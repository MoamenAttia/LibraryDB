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
        int Rate;
        public Music_Instrument_Details_Form(string Music_InsName, string Music_InsPrice, string Music_InsSeciton, byte[] image, int UserID, string Status, int instrumentUserID, int Instrument_ID, int LastRate)
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
            Rate = LastRate;
            RateLabel.Text = "Rate = "+Rate.ToString();
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
            int AvailableSeats = int.Parse(Controller_OBJ.GetMusicDepAvailableSeats().Rows[0].ItemArray[0].ToString());
            if(AvailableSeats<1) { MessageBox.Show("Sorry Sir There is no Seat for you", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            int Success = Controller_OBJ.UpdateInstrumentStatusAndInstrumentUserID(userid, InstrumentIDvar, Instrument_Typevar, 3, "InUse");
            if (Success == 1) MessageBox.Show("This Instrument has been reserved for you");
            Controller_OBJ.UpdateAvailableSeats(3, AvailableSeats - 1);
            UpdateForm();
        }

        private void ReturnBtn_Click_1(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.UpdateInstrumentStatusAndInstrumentUserID_NULL(InstrumentIDvar, Instrument_Typevar, 3, "Available");
            if (Success == 1) MessageBox.Show("This Instrument has been unreserved");
            Controller_OBJ.UpdateAvailableSeats(3, int.Parse(Controller_OBJ.GetMusicDepAvailableSeats().Rows[0].ItemArray[0].ToString()) + 1);
            UpdateForm();
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {

            if (VeryPoor.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 3, (int)((1 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as Verypoor");
            }
            else if (Poor.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 3, (int)((2 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as poor");
            }
            else if (Good.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 3, (int)((3 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as Good");
            }
            else if (VeryGood.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 3, (int)((4 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as VeryGood");
            }
            else if (Excellent.Checked)
            {
                int Success = Controller_OBJ.RateInstrument(InstrumentIDvar, Instrument_Typevar, 3, (int)((5 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as Excellent");
            }
            UpdateForm();
        }
        private void UpdateForm()
        {
            DataTable dt = Controller_OBJ.GetMusical_InstrumentByName(InstrumentIDvar, 3, SectionNameLabel.Text);
            Rate = int.Parse(dt.Rows[0].ItemArray[8].ToString());
            RateLabel.Text = "Rate = " + Rate.ToString();
            status = dt.Rows[0].ItemArray[2].ToString();
            if (!DBNull.Value.Equals(dt.Rows[0].ItemArray[4]))
            {
                InstrumentUserID = int.Parse(dt.Rows[0].ItemArray[4].ToString());
                //not null
            }
            else
            {
                InstrumentUserID = 0;
                //null
            }
            ReserveBtn.Visible = ReturnBtn.Visible = InUse.Visible = false;
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
    }
}
