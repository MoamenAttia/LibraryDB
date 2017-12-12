using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egypt_National_Library
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
       
        public int Add_Library_Department(int Lib_Dep_ID , string Lib_Dep_Name , DateTime Construction_Date , string Services_Can_Provide , int Available_Seats , int Supervisor_ID)
        {
            string StoredProcedureName = StoredProcedures.AddLibraryDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Lib_Dep_ID", Lib_Dep_ID);
            Parameters.Add("@Lib_Dep_Name", Lib_Dep_Name);
            Parameters.Add("@Construction_Date", Construction_Date.Date);
            Parameters.Add("@Services_Can_Provide", Services_Can_Provide);
            Parameters.Add("@Available_Seats", Available_Seats);
            Parameters.Add("@Supervisor_ID", Supervisor_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Add_Book_Section(string Book_Sec_Name, int No_Books,int Lib_Dep_ID)
        {
            string StoredProcedureName = StoredProcedures.AddBookSection;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_Sec_Name", Book_Sec_Name);
            Parameters.Add("@No_Of_Books", No_Books);
            Parameters.Add("@Book_Lib_Dep_ID", Lib_Dep_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}
