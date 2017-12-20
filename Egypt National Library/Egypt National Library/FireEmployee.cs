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
    public partial class FireEmployee : Form
    {
        ChairmanForm cf;
        Controller cobj;
        DataTable Dt;
        public FireEmployee(ChairmanForm c)
        {
            cobj = new Controller();
            cf = c;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            cf.Close();
            Environment.Exit(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out i))
            {
                MsgShow mm = new MsgShow("Invalid ID!");
                mm.ShowDialog();
                return;
            }
            Dt = cobj.Get_Emp_Job(i);
            if (Dt == null || Convert.ToString(Dt.Rows[0]["Job_Title"]) == "")
            {
                MsgShow mm = new MsgShow("Invalid ID!");
                mm.ShowDialog();
                return;
            }
            if (Convert.ToString(Dt.Rows[0]["Job_Title"]) == "General Manager")
            {
                MsgShow mm = new MsgShow("Cannot Fire The Chairman!");
                mm.ShowDialog();
                return;
            }
            else 
            {
                DataTable temp = cobj.Count_Employees_under_Job(Convert.ToString(Dt.Rows[0]["Job_Title"]));
                if (Convert.ToInt32(temp.Rows[0]["N_Of_Emp"]) <= 1)
                {
                    MsgShow mm = new MsgShow("Cannot Fire The only " + Convert.ToString(Dt.Rows[0]["Job_Title"]) + "!");
                    mm.ShowDialog();
                    return;
                }
                else
                {
                    if (Convert.ToString(Dt.Rows[0]["Job_Title"]).Contains("Super Visor"))
                    {
                        DataTable temp1;
                        temp1 = cobj.Get_Employee_by_Manager(i);
                        DataTable temp2;
                        temp2 = cobj.Count_Employees_under_Manager(i);
                        int count = Convert.ToInt32(temp2.Rows[0]["N_Of_Emp"]);
                        temp2 = cobj.Get_Employee_by_Job(Convert.ToString(Dt.Rows[0]["Job_Title"]));
                        int newid = Convert.ToInt32(temp2.Rows[0]["Emp_ID"]);
                        if (i == newid)
                        {
                            newid = Convert.ToInt32(temp2.Rows[1]["Emp_ID"]);
                        }
                        for (int z = 0;z<count;z++)
                        {
                            cobj.Edit_Emp_Manager(Convert.ToInt32(temp1.Rows[z]["Emp_ID"]), newid);
                        }
                    }
                    else
                    {
                        DataTable iii = cobj.Get_Emp_ManagerID(Convert.ToInt32(textBox1.Text));
                        int t_mid = Convert.ToInt32(iii.Rows[0]["Manager_ID"]);
                        iii = cobj.Count_Employees_under_Manager(t_mid);
                        int c = Convert.ToInt32(iii.Rows[0]["N_Of_Emp"]);
                        if (c <= 1)
                        {
                            MsgShow ddd = new MsgShow("Cannot Delete the Only Emp For A Manager!");
                            ddd.ShowDialog();
                            return;
                        }
                    }
                    cobj.Fire_Emp(i);
                    MsgShow mm = new MsgShow("Done!");
                    mm.ShowDialog();
                    return;
                }
            }
        }
    }
}
