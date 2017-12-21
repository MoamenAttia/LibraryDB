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
   
    public partial class Story_Details_Form : Form
    {
    
        string status;
        int userid;
        int StoryUserID;
        int StoryIDvar;
        string Story_Typevar;
        Controller Controller_OBJ;
        int Rate;
        string StName, StPrice, SecName;
        byte[] Img;

        public Story_Details_Form(string StroyName,string StoryPrice,string SectionName,byte[] image,int UserID, string Status, int storyUserID, int Story_ID,int LastRate)
        {
            Controller_OBJ = new Controller();
            InitializeComponent();
            StoryNameLabel.Text = StroyName;
            SectionNameLabel.Text = SectionName;
            PriceLabel.Text = StoryPrice + " LE";
            MemoryStream ms = new MemoryStream(image);
            Story_ImagePicturebox.Image = Image.FromStream(ms);
            Story_ImagePicturebox.Refresh();
            userid = UserID;
            status = Status;
            StoryUserID = storyUserID;
            StoryIDvar =Story_ID;
            Story_Typevar = SectionName;
            Rate = LastRate;
            StName = StroyName;
            StPrice = StoryPrice;
            SecName = SectionName;
            Img = image;
            Story_RateLabel.Text = "Rate = "+ Rate.ToString();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Story_Details_Form_Load(object sender, EventArgs e)
        {
            if (status == "Available" && StoryUserID == 0)
            {
                BorrowBtn.Enabled = true;
                BorrowBtn.Visible = true;
            }
            else
            {
                if (userid == StoryUserID)
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

        private void BorrowBtn_Click_1(object sender, EventArgs e)
        {
            int AvailableSeats = int.Parse(Controller_OBJ.GetStoryDepAvailableSeats().Rows[0].ItemArray[0].ToString());
            int Success = Controller_OBJ.UpdateStoryStatusAndStoryUserID(userid, StoryIDvar, Story_Typevar, 2, "InUse");
            if (AvailableSeats < 1) { MessageBox.Show("Sorry Sir There is no Seat for you", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Controller_OBJ.UpdateAvailableSeats(2, AvailableSeats - 1);
            if (Success == 1) MessageBox.Show("This Story has been added to your Stories");
            UpdateForm();
        }

        private void ReturnBtn_Click_1(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.UpdateStoryStatusAndStoryUserID_NULL(StoryIDvar, Story_Typevar, 2, "Available");
            Controller_OBJ.UpdateAvailableSeats(2, int.Parse(Controller_OBJ.GetStoryDepAvailableSeats().Rows[0].ItemArray[0].ToString()) + 1);
            if (Success == 1) MessageBox.Show("This Story has been removed from your Stories");
            UpdateForm();
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {

            if (VeryPoor.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, (int)((1+Rate)/2.0f));
                if (Success == 1) MessageBox.Show("You rated this as Verypoor");
            }
            else if (Poor.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, (int)((2 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as poor");
            }
            else if (Good.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, (int)((3 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as Good");
            }
            else if (VeryGood.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, (int)((4 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as VeryGood");
            }
            else if (Excellent.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, (int)((5 + Rate) / 2.0f));
                if (Success == 1) MessageBox.Show("You rated this as Excellent");
            }
            this.UpdateForm();
        }
        private void UpdateForm()
        {
            DataTable dt = Controller_OBJ.GetStoryByName(StoryIDvar, 2, SectionNameLabel.Text);
            Rate = int.Parse(dt.Rows[0].ItemArray[8].ToString());
            Story_RateLabel.Text = "Rate = " + Rate.ToString();
            status = dt.Rows[0].ItemArray[9].ToString();
            if (!DBNull.Value.Equals(dt.Rows[0].ItemArray[6]))
            {
                StoryUserID = int.Parse(dt.Rows[0].ItemArray[6].ToString());
                //not null
            }
            else
            {
                StoryUserID = 0;
                //null
            }
            BorrowBtn.Visible = ReturnBtn.Visible = InUse.Visible = false;
            if (status == "Available" && StoryUserID == 0)
            {
                BorrowBtn.Enabled = true;
                BorrowBtn.Visible = true;
            }
            else
            {
                if (userid == StoryUserID)
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
