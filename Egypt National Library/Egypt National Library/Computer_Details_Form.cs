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
        public Computer_Details_Form(Panel[] SoftwarePanels,int NumOfPictureboxes,string price,string Cmp_Type,byte[] OperatingSystemImage,string OpSys)
        {
            
            InitializeComponent();
            for (int i = 0; i < NumOfPictureboxes; ++i)
                Controls.Add(SoftwarePanels[i]);

            PriceLabel.Text = price;
            SectionNameLabel.Text = Cmp_Type;
            MemoryStream ms = new MemoryStream(OperatingSystemImage);
            CmpPicturebox.Image = Image.FromStream(ms);
            CmpPicturebox.Refresh();
            OperationSystemName.Text = OpSys;
        }

        private void Computer_Details_Form_Load(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
