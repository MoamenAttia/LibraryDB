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
        public Music_Instrument_Details_Form(string Music_InsName, string Music_InsPrice, string Music_IncSeciton, byte[] image)
        {
            InitializeComponent();
            Music_Name.Text = Music_InsName;
            PriceLabel.Text = Music_InsPrice;
            SectionNameLabel.Text = Music_IncSeciton;
            MemoryStream ms = new MemoryStream(image);
            MusicIns_ImagePicturebox.Image = Image.FromStream(ms);
            MusicIns_ImagePicturebox.Refresh();
        }

        private void Music_Instrument_Details_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
