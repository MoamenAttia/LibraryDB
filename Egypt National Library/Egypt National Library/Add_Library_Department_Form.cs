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
        Controller Controller_OBJ;
        public Add_Library_Department_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }

        private void Add_Library_Dep_Click(object sender, EventArgs e)
        {
            DateTime Construction_Date = new DateTime(2000, 1, 1);
            Construction_Date =Construction_Date.AddDays(DayCombobox.SelectedIndex);
            Construction_Date=Construction_Date.AddMonths(MonthcomboBox.SelectedIndex+1);
            Construction_Date=Construction_Date.AddYears(int.Parse(YearComboBox.Text) - 2000);

            int Success = Controller_OBJ.Add_Library_Department(int.Parse(Lib_Dep_ID.Text), Lib_Dep_Name.Text, Construction_Date, Services_Can_Provide.Text, int.Parse(Available_Seats.Text), int.Parse(Supervisor_ID.Text));
            if (Success == 0)
                MessageBox.Show("Failed To Add A new Library Departmen", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("A new Library Department has been added Successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Library_Department_Form_Load(object sender, EventArgs e)
        {
            string[] Days = new string[30];
            for (int i = 0; i < 30; ++i)
                Days[i] = (i + 1).ToString();

            string[] Years = new string[30];
            for (int i = 0; i < 30; ++i)
                Years[i] = (1980 + i).ToString();

            string[] Months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            DayCombobox.Items.AddRange(Days);
            MonthcomboBox.Items.AddRange(Months);
            YearComboBox.Items.AddRange(Years);
        }
    }
}
