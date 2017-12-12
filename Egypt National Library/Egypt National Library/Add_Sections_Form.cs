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
    public partial class Add_Sections_Form : Form
    {
        Controller Controller_OBJ;
        public Add_Sections_Form()
        {
            InitializeComponent();
            Controller_OBJ = new Controller();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Book_Section_Click(object sender, EventArgs e)
        {
            int Success = Controller_OBJ.Add_Book_Section(Book_Sec_Name.Text, int.Parse(No_Books.Text), int.Parse(Books_Lib_Dep_ID.Text));
            if (Success == 0)
                MessageBox.Show("Failed To Add A new Book Section", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("A new Book Section has been added Successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
