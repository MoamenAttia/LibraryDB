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

// Location of Panels like Book Sections ... is 225,35
// Label to show num of available seats AvSeatsLabel
// El7aga.Font = new Font("",size,FontStyle.bold);
/*Each panel has a location (225,60) size 214*260 has a pic box of size 214*192 has a label (1,200)*/
namespace Egypt_National_Library
{
    public partial class User_Form : Form
    {
        Panel ActivePanel = new Panel();
        DataTable dataTable = new DataTable();
        Controller Controller_OBJ;
        public User_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }
        private void User_Form_Load(object sender, EventArgs e)
        {
            Point Location = new Point(225, 35);
            LibDepsPanel.Location = MusicDepPanel.Location = BookDepPanel.Location = StoryDepPanel.Location = CmpDepPanel.Location = Location;
            dataTable = Controller_OBJ.GetBookDepAvailableSeats();
            AvSeatsLabel.Text = dataTable.Rows[0].ItemArray[0].ToString();
            dataTable = Controller_OBJ.GetStoryDepAvailableSeats();
            StoryDepAvailableSeats.Text= dataTable.Rows[0].ItemArray[0].ToString();
            dataTable = Controller_OBJ.GetMusicDepAvailableSeats();
            MusicDepAvSeats.Text = dataTable.Rows[0].ItemArray[0].ToString();
            dataTable = Controller_OBJ.GetCmpDepAvailableSeats();
            CmpDepAvSeats.Text= dataTable.Rows[0].ItemArray[0].ToString();

        }
        private void closeButton_Click(object sender, EventArgs e) { this.Close(); }
        private void LibDepBtn_Click(object sender, EventArgs e)    { ActivatePanel(LibDepsPanel);   }
        private void BookDepBtn_Click(object sender, EventArgs e)  { ActivatePanel(BookDepPanel);   }
        private void StoryDepBtn_Click(object sender, EventArgs e) { ActivatePanel(StoryDepPanel);  }
        private void MusicDepBtn_Click(object sender, EventArgs e) { ActivatePanel(MusicDepPanel); }
        private void CmpDepBtn_Click(object sender, EventArgs e) { ActivatePanel(CmpDepPanel); }
        private void ActivatePanel(Panel panel){ ActivePanel.Visible = false; ActivePanel = panel; ActivePanel.Show(); }
        private void Label_Click(object sender,EventArgs e)
        {
            MessageBox.Show("Hello");
        }
        //Book Department Buttons Click ,, showing panels of each Book Department//
        private void ProgrammingDepBtn_Click(object sender, EventArgs e){ Show_Book_Panels("Programming", 1); }
        private void BabyCareDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Baby Care", 1); }
        private void ScienceDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Science", 1); }
        private void ReligiousDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Religious", 1);}
        private void GeographyDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Geographic", 1); }
        private void HealthDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Health", 1); }
        private void HumanDevDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Human Development", 1); }
        private void NutritionDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Nutrition", 1); }
        private void ArabLitDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Literature", 1); }
        private void HistoryDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("History", 1); }
        private void MathsDepBtn_Click(object sender, EventArgs e) { Show_Book_Panels("Maths", 1); }
        //----------------------------------------------------------------------------------------------------------//
        //Story Department Buttons Click ,, showing panels of each Story Department//
        private void HorrorDepBtn_Click(object sender, EventArgs e) { Show_Stories_Panels("Horror", 2); }
        private void RomanticDepBtn_Click(object sender, EventArgs e) { Show_Stories_Panels("Romantic", 2); }
        private void DramaDepBtn_Click(object sender, EventArgs e) { Show_Stories_Panels("Drama", 2); }
        private void LearningDepBtn_Click(object sender, EventArgs e) { Show_Stories_Panels("Learning", 2); }
        //----------------------------------------------------------------------------------------------------------//
        //Music Department Buttons Click ,, showing panels of each Music Department//
        private void DrumsDepBtn_Click(object sender, EventArgs e) { Show_Instruments_Panels("Drums", 3); }
        private void GuitarDepBtn_Click(object sender, EventArgs e) { Show_Instruments_Panels("Guitar", 3); }
        private void MicrophonesDepBtn_Click(object sender, EventArgs e) { Show_Instruments_Panels("Microphones&HeadSets", 3); }
        private void PianoDepBtn_Click(object sender, EventArgs e) { Show_Instruments_Panels("Piano", 3); }
        //----------------------------------------------------------------------------------------------------------//
        //Computer Department Buttons Click ,, showing panels of each Computer Department//
        private void ArchitectureDepBtn_Click(object sender, EventArgs e) { Show_Computers_Panels("Architecture", 4); }
        private void PowerEngineeringDepBtn_Click(object sender, EventArgs e) { Show_Computers_Panels("Power Engineering", 4); }
        private void SoftwareDepBtn_Click(object sender, EventArgs e) { Show_Computers_Panels("SoftWare Engineering", 4); }
        //----------------------------------------------------------------------------------------------------------//
        private Panel CreatePanel(int i,Color Backcolor,int width,int height,int locationX,int locationY)
        {
            Panel panel = new Panel();
            panel.Name = "myPanel" + i.ToString();
            panel.BackColor = Backcolor;
            panel.Width = width;
            panel.Height = height;
            panel.Location = new Point(locationX, locationY);
            return panel;
        }
        private void InesertControlToPanel(ref Panel panel, ref LinkLabel label, ref PictureBox pictureBox)
        {
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);
            //-----------Edit Options for the picture box-----------------//
            panel.Controls[0].Width = panel.Width;
            panel.Controls[0].Height = 192;
            panel.Controls[0].Location = new Point(0, 0);

            //----------Edit Options for the Label------------------//
            panel.Controls[1].Width = panel.Width;
            panel.Controls[1].Height = 60;
            panel.Controls[1].Location = new Point(1, 200);

        }
        private LinkLabel CreateLabel(int i,string text)
        {
            LinkLabel label = new LinkLabel();
            label.Name = "myLabel" + i.ToString();
            label.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            label.LinkBehavior = LinkBehavior.NeverUnderline;
            label.TextAlign = ContentAlignment.TopCenter;
            label.Click += new System.EventHandler(this.Label_Click);
            label.LinkColor = Color.FromArgb(1, 66, 66, 66);
            label.ActiveLinkColor = Color.DarkSalmon;
            label.Text = text;
            return label;
        }
        private PictureBox CreatePicturebox(int i,byte[] image)
        {
            PictureBox picturebox = new PictureBox();
            picturebox.Name = "myPictureBox" + i.ToString();
            MemoryStream ms = new MemoryStream(image);
            picturebox.Image = Image.FromStream(ms);
            picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            picturebox.Refresh();
            picturebox.Click += new System.EventHandler(this.Label_Click);
            return picturebox;
        }

        private void Show_Book_Panels(string type,int libDepID)
        {
            ActivePanel.Visible = false;
            dataTable = Controller_OBJ.GetSpecificBooks(type, libDepID);
            int Num_OF_Panels = dataTable.Rows.Count;
            Panel[] Panels = new Panel[Num_OF_Panels];
            PictureBox[] pictureboxes = new PictureBox[Num_OF_Panels];
            LinkLabel[] Labels = new LinkLabel[Num_OF_Panels];
            int incrementer = 1, rows = 1;
            for (int i = 0; i < Num_OF_Panels; ++i)
            {
                if (incrementer == 5) { rows++; incrementer = 1; }
                Panels[i] = CreatePanel(i, Color.Snow, 214, 260, 225 * (incrementer++), 75 + (rows - 1) * 300);
                Labels[i] = CreateLabel(i, dataTable.Rows[i].ItemArray[6].ToString());
                pictureboxes[i] = CreatePicturebox(i, (byte[])dataTable.Rows[i].ItemArray[14]);
                InesertControlToPanel(ref Panels[i], ref Labels[i], ref pictureboxes[i]);
                Controls.Add(Panels[i]);
            }
        }
        private void Show_Stories_Panels(string type, int libDepID)
        {
            ActivePanel.Visible = false;
            dataTable = Controller_OBJ.GetSpecificStories(type, libDepID);
            int Num_OF_Panels = dataTable.Rows.Count;
            Panel[] Panels = new Panel[Num_OF_Panels];
            PictureBox[] pictureboxes = new PictureBox[Num_OF_Panels];
            LinkLabel[] Labels = new LinkLabel[Num_OF_Panels];
            int incrementer = 1, rows = 1;
            for (int i = 0; i < Num_OF_Panels; ++i)
            {
                if (incrementer == 5) { rows++; incrementer = 1; }
                Panels[i] = CreatePanel(i, Color.Snow, 214, 260, 225 * (incrementer++), 75 + (rows - 1) * 300);
                Labels[i] = CreateLabel(i, dataTable.Rows[i].ItemArray[1].ToString());
                pictureboxes[i] = CreatePicturebox(i, (byte[])dataTable.Rows[i].ItemArray[7]);
                InesertControlToPanel(ref Panels[i], ref Labels[i], ref pictureboxes[i]);
                Controls.Add(Panels[i]);
            }
        }
        private void Show_Instruments_Panels(string type, int libDepID)
        {
            ActivePanel.Visible = false;
            dataTable = Controller_OBJ.GetSpecificInstruments(type, libDepID);
            int Num_OF_Panels = dataTable.Rows.Count;
            Panel[] Panels = new Panel[Num_OF_Panels];
            PictureBox[] pictureboxes = new PictureBox[Num_OF_Panels];
            LinkLabel[] Labels = new LinkLabel[Num_OF_Panels];
            int incrementer = 1, rows = 1;
            for (int i = 0; i < Num_OF_Panels; ++i)
            {
                if (incrementer == 5) { rows++; incrementer = 1; }
                Panels[i] = CreatePanel(i, Color.Snow, 214, 260, 225 * (incrementer++), 75 + (rows - 1) * 300);
                Labels[i] = CreateLabel(i, dataTable.Rows[i].ItemArray[1].ToString());
                pictureboxes[i] = CreatePicturebox(i, (byte[])dataTable.Rows[i].ItemArray[7]);
                InesertControlToPanel(ref Panels[i], ref Labels[i], ref pictureboxes[i]);
                Controls.Add(Panels[i]);
            }
        }
        private void Show_Computers_Panels(string type, int libDepID)
        {
            ActivePanel.Visible = false;
            dataTable = Controller_OBJ.GetSpecificComputers(type, libDepID);
            int Num_OF_Panels = dataTable.Rows.Count;
            Panel[] Panels = new Panel[Num_OF_Panels];
            PictureBox[] pictureboxes = new PictureBox[Num_OF_Panels];
            LinkLabel[] Labels = new LinkLabel[Num_OF_Panels];
            int incrementer = 1, rows = 1;
            for (int i = 0; i < Num_OF_Panels; ++i)
            {
                if (incrementer == 5) { rows++; incrementer = 1; }
                Panels[i] = CreatePanel(i, Color.Snow, 214, 260, 225 * (incrementer++), 75 + (rows - 1) * 300);
                Labels[i] = CreateLabel(i, dataTable.Rows[i].ItemArray[1].ToString());
                pictureboxes[i] = CreatePicturebox(i, (byte[])dataTable.Rows[i].ItemArray[7]);
                InesertControlToPanel(ref Panels[i], ref Labels[i], ref pictureboxes[i]);
                Controls.Add(Panels[i]);
            }
        }


    }
}
