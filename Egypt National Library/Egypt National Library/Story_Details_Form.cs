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
        public Story_Details_Form(string StroyName,string StoryPrice,string SectionName,byte[] image,int UserID, string Status, int storyUserID, int Story_ID)
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
            int Success = Controller_OBJ.UpdateStoryStatusAndStoryUserID(userid, StoryIDvar, Story_Typevar, 2, "InUse");
            if (Success == 1) MessageBox.Show("This Story has been added to your Stories");
        }

        private void ReturnBtn_Click_1(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.UpdateStoryStatusAndStoryUserID_NULL(StoryIDvar, Story_Typevar, 2, "Available");
            if (Success == 1) MessageBox.Show("This Story has been removed from your Stories");
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {

            if (VeryPoor.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, 1);
                if (Success == 1) MessageBox.Show("You rated this as Verypoor");
            }
            else if (Poor.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar,2, 2);
                if (Success == 1) MessageBox.Show("You rated this as poor");
            }
            else if (Good.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, 3);
                if (Success == 1) MessageBox.Show("You rated this as Good");
            }
            else if (VeryGood.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, 4);
                if (Success == 1) MessageBox.Show("You rated this as VeryGood");
            }
            else if (Excellent.Checked)
            {
                int Success = Controller_OBJ.RateStory(StoryIDvar, Story_Typevar, 2, 5);
                if (Success == 1) MessageBox.Show("You rated this as Excellent");
            }
        }
    }
}
