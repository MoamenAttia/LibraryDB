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
        public Book_Details_Form(string AuthorFName, string AuthorMName, string AuthorLName, string Price, string Publisher,string SectionName,string ReleaseDate,byte[]image)
        {
            InitializeComponent();
            AuthorFNameLabel.Text = AuthorFName;
            AuthorMNameLabel.Text = AuthorMName;
            AuthorLNameLabel.Text = AuthorLName;
            PriceLabel.Text = Price;
            PublisherLabel.Text = Publisher;
            SectionNameLabel.Text = SectionName;
            ReleaseDateLabel.Text = ReleaseDate;
            MemoryStream ms = new MemoryStream(image);
            Book_ImagePicturebox.Image = Image.FromStream(ms);
            

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Book_Details_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
