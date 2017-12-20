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
    public partial class Computer_Details_Form : Form
    {
        Controller Controller_OBJ;
        string status;
        int userid;
        int CmpUserID;
        int CmpIDvar;
        string Cmp_Typevar;
        public Computer_Details_Form(Panel[] SoftwarePanels,int NumOfPictureboxes,string price,string Cmp_Type,byte[] OperatingSystemImage,string OpSys,int UserID, string Status, int cmpUserID, int Cmp_ID)
        {

            Controller_OBJ = new Controller();
            InitializeComponent();
            for (int i = 0; i < NumOfPictureboxes; ++i)
                Controls.Add(SoftwarePanels[i]);

            PriceLabel.Text = price;
            SectionNameLabel.Text = Cmp_Type;
            MemoryStream ms = new MemoryStream(OperatingSystemImage);
            CmpPicturebox.Image = Image.FromStream(ms);
            CmpPicturebox.Refresh();
            OperationSystemName.Text = OpSys;
            userid = UserID;
            status = Status;
            CmpUserID = cmpUserID;
            CmpIDvar = Cmp_ID;
            Cmp_Typevar = Cmp_Type;
        }

        private void Computer_Details_Form_Load(object sender, EventArgs e)
        {
            if (status == "Available" && CmpUserID == 0)
            {
                ReserveBtn.Enabled = true;
                ReserveBtn.Visible = true;
            }
            else
            {
                if (userid == CmpUserID)
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

        private void ReserveBtn_Click_1(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.UpdateCmpStatusAndCmpUserID(userid, CmpIDvar, Cmp_Typevar, 4, "InUse");
            if (Success == 1) MessageBox.Show("This Computer has been reserved for you");
        }

        private void ReturnBtn_Click_1(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.UpdateCmpStatusAndCmpUserID_NULL(CmpIDvar, Cmp_Typevar, 4, "Available");
            if (Success == 1) MessageBox.Show("This Computer has been unreserved");

        }

        private void RateBtn_Click(object sender, EventArgs e)
        {
            if (VeryPoor.Checked)
            {
                int Success = Controller_OBJ.RateCmp(CmpIDvar, Cmp_Typevar, 4, 1);
                if (Success == 1) MessageBox.Show("You rated this as Verypoor");
            }
            else if (Poor.Checked)
            {
                int Success = Controller_OBJ.RateCmp(CmpIDvar, Cmp_Typevar, 4, 2);
                if (Success == 1) MessageBox.Show("You rated this as poor");
            }
            else if (Good.Checked)
            {
                int Success = Controller_OBJ.RateCmp(CmpIDvar,Cmp_Typevar, 4, 3);
                if (Success == 1) MessageBox.Show("You rated this as Good");
            }
            else if (VeryGood.Checked)
            {
                int Success = Controller_OBJ.RateCmp(CmpIDvar, Cmp_Typevar, 4, 4);
                if (Success == 1) MessageBox.Show("You rated this as VeryGood");
            }
            else if (Excellent.Checked)
            {
                int Success = Controller_OBJ.RateCmp(CmpIDvar, Cmp_Typevar, 4, 5);
                if (Success == 1) MessageBox.Show("You rated this as Excellent");
            }
        }
    }
}
