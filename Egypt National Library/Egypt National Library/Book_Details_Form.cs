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
    public partial class Book_Details_Form : Form
    {

        string status;
        int userid;
        int BookUserID;
        int BookIDvar;
        string Book_Typevar;
        Controller Controller_OBJ;
        public Book_Details_Form(string Name,string AuthorFName, string AuthorMName, string AuthorLName, string Price, string Publisher,string SectionName,string ReleaseDate,byte[]image,int UserID,string Status,int bookUserID,int Book_ID)
        {
           
            InitializeComponent();
            Controller_OBJ = new Controller();
            AuthorFNameLabel.Text = AuthorFName;
            AuthorMNameLabel.Text = AuthorMName;
            AuthorLNameLabel.Text = AuthorLName;
            BookNameLabel.Text = Name;
            PriceLabel.Text = Price + " LE";
            PublisherLabel.Text = Publisher;
            SectionNameLabel.Text = SectionName;
            ReleaseDateLabel.Text = ReleaseDate;
            MemoryStream ms = new MemoryStream(image);
            Book_ImagePicturebox.Image = Image.FromStream(ms);
            userid = UserID;
            status = Status;
            BookUserID = bookUserID;
            BookIDvar=Book_ID;
            Book_Typevar = SectionName;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Book_Details_Form_Load(object sender, EventArgs e)
        {
            if (status == "Available"&&BookUserID==0)
            {
                BorrowBtn.Enabled = true;
                BorrowBtn.Visible = true;
            }
            else 
            {
                if (userid == BookUserID)
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


        private void BorrowBtn_Click(object sender, EventArgs e)
        {
           int Success= Controller_OBJ.UpdateBookStatusAndBookUserID(userid, BookIDvar, Book_Typevar, 1, "InUse");
           if (Success == 1) MessageBox.Show("This Book has been added to your Books");
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.UpdateBookStatusAndBookUserID_NULL(BookIDvar, Book_Typevar, 1, "Available");
            if (Success == 1) MessageBox.Show("This Book has been removed from your Books");
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {
            if (VeryPoor.Checked)
            {
                int Success = Controller_OBJ.RateBook(BookIDvar, Book_Typevar, 1, 1);
                if (Success == 1) MessageBox.Show("You rated this as Verypoor");
            }
            else if (Poor.Checked)
            {
                int Success = Controller_OBJ.RateBook(BookIDvar, Book_Typevar, 1, 2);
                 if (Success == 1) MessageBox.Show("You rated this as poor");
            }
            else if (Good.Checked)
            {
                int Success = Controller_OBJ.RateBook(BookIDvar, Book_Typevar, 1, 3);
                 if (Success == 1) MessageBox.Show("You rated this as Good");
            }
            else if (VeryGood.Checked)
            {
                int Success = Controller_OBJ.RateBook(BookIDvar, Book_Typevar, 1, 4);
                if (Success == 1) MessageBox.Show("You rated this as VeryGood");
            }
            else if (Excellent.Checked)
            {
                int Success = Controller_OBJ.RateBook(BookIDvar, Book_Typevar, 1, 5);
                if (Success == 1) MessageBox.Show("You rated this as Excellent");
            }

        }
    }
}
