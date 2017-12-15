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
    
    public partial class Add_Book_Form : Form
    {
        
        Controller Controller_OBJ;
        public Add_Book_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }
        private void Add_Book_Form_Load(object sender, EventArgs e)
        {

        }
        private void Browse_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialogobj = new OpenFileDialog();
            OpenFileDialogobj.Filter = "Images | *.jpg; *.png";
            if (OpenFileDialogobj.ShowDialog() == DialogResult.OK)
                PictureBox.Image = Image.FromFile(OpenFileDialogobj.FileName);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        { 
            MemoryStream ms = new MemoryStream();
            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat);
            byte[] image = ms.ToArray();

            int Year = CheckYearValidation(); int Month = CheckMonthValidation();  int Day = CheckDayValidation();
            int Book_id = Check_IDValidation(Book_ID.Text, "Book"); int price = CheckPriceValidation();
            int Book_Lib_Dep_id = Check_IDValidation(Book_Lib_Dep_ID.Text, "Lib Dep");
            if (Year == 0 || Month == 0 || Day == 0 || Book_id == 0 || price == 0 || Book_Lib_Dep_id == 0) { return; }
            string Construction_Date = Day.ToString() + "/" + Month.ToString() + "/" + Year.ToString();

            int Success = Controller_OBJ.Add_Book(AuthorFName.Text, AuthorMName.Text, AuthorLName.Text
                , Book_id, Construction_Date, Book_Name.Text, price, Publisher.Text, "Available",
               Book_Sec_Name.Text, Book_Lib_Dep_id, image);
            if (Success == 0)
                MessageBox.Show("Failed To Add A new Book", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("A New Book has been added Successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private int CheckYearValidation()
        {
            int Year = 0;
            try { Year = int.Parse(YearTextbox.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid Year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (Year > 2018)
            { MessageBox.Show("Please Sir , Add A valid Year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return Year;
        }
        private int CheckDayValidation()
        {
            int Day = 0;
            try { Day = int.Parse(DayTextbox.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid Day", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (Day > 31 || Day < 1)
            { MessageBox.Show("Please Sir , Add A valid Day", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return Day;
        }
        private int CheckMonthValidation()
        {
            int Month = 0;
            try { Month = int.Parse(MonthTextbox.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid Month", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (Month > 12 || Month < 1)
            { MessageBox.Show("Please Sir , Add A valid Month", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return Month;
        }
        private int Check_IDValidation(string Text,string type)
        {
            int ID = 0;
            try { ID = int.Parse(Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid "+type+" ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (ID < 1)
            { MessageBox.Show("Please Sir , Add A valid " + type + " ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return ID;
        }
        private int CheckPriceValidation()
        {
            int price = 0;
            try { price = int.Parse(Price.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (price < 1)
            { MessageBox.Show("Please Sir , Add A valid Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return price;
        }
    }
}
