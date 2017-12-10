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
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
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
