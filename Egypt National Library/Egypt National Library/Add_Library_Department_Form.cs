using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egypt_National_Library
{
    public partial class Add_Library_Department_Form : Form
    {
       // int[] Validation = new int[7];  //ID,Dep_Name,Day,Month,Year,AvailableSeats,SupervisorID
        Controller Controller_OBJ;
        public Add_Library_Department_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }

        private void Add_Library_Dep_Click(object sender, EventArgs e)
        {
            int Year = CheckYearValidation(); int Month = CheckMonthValidation(); int Day = CheckDayValidation();
            int ID = Check_IDValidation(Lib_Dep_ID); int Supervisor_id = Check_IDValidation(Supervisor_ID); int AvailableSeats = CheckAvailableSeatsValidation();
            if (Year == 0 || Day == 0 || Month == 0 || ID == 0 || Supervisor_id == 0 || AvailableSeats == 0) { return; }
            string Construction_Date = Day.ToString() + "/" + Month.ToString() + "/" + Year.ToString();
            int Success = Controller_OBJ.Add_Library_Department(ID, Lib_Dep_Name.Text, Construction_Date, Services_Can_Provide.Text,AvailableSeats, Supervisor_id);
            if (Success == 0)
               MessageBox.Show("Failed To Add A new Library Department", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
               MessageBox.Show("A New Library Department has been added Successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Library_Department_Form_Load(object sender, EventArgs e)
        {
            
        }
        private int CheckYearValidation()
        {
            int Year = 0;
            try { Year = int.Parse(YearTextbox.Text); }
            catch(Exception Ex) { MessageBox.Show("Please Sir , Add A valid Year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
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
        private int Check_IDValidation(Control Textbox)
        {
            int ID = 0;
            try { ID = int.Parse(Textbox.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (ID < 1)
            { MessageBox.Show("Please Sir , Add A valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return ID;
        }
        private int CheckAvailableSeatsValidation()
        {
            int AvailableSeats = 0;
            try { AvailableSeats = int.Parse(Available_Seats.Text); }
            catch (Exception Ex) { MessageBox.Show("Please Sir , Add A valid Num For Seats", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            if (AvailableSeats < 1)
            { MessageBox.Show("Please Sir , Add A valid Num For Seats", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return 0; }
            return AvailableSeats;
        }
        
    }
}
