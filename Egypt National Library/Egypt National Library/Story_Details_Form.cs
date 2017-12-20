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
        public Story_Details_Form(string StroyName,string StoryPrice,string SectionName,byte[] image,int UserID)
        {
            InitializeComponent();
            StoryNameLabel.Text = StroyName;
            SectionNameLabel.Text = SectionName;
            PriceLabel.Text = StoryPrice + " LE";
            MemoryStream ms = new MemoryStream(image);
            Story_ImagePicturebox.Image = Image.FromStream(ms);
            Story_ImagePicturebox.Refresh();
            int userid = UserID;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Story_Details_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
