using System;
using System.Collections.Generic;
using System.Data;
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
       
        public int Add_Library_Department(int Lib_Dep_ID , string Lib_Dep_Name , string Construction_Date , string Services_Can_Provide , int Available_Seats , int Supervisor_ID)
        {
            string StoredProcedureName = StoredProcedures.AddLibraryDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Lib_Dep_ID", Lib_Dep_ID);
            Parameters.Add("@Lib_Dep_Name", Lib_Dep_Name);
            Parameters.Add("@Construction_Date", Construction_Date);
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
        public int Add_Book(string AuthorFName, string AuthorMName, string AuthorLName, int Book_id, string Release_Date
            , string Book_Name, int price, string publisher, string Book_Status
           , string Book_Type, int Book_Dep, byte[] Book_Image)
        {
            string StoredProcedureName = StoredProcedures.AddBook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Author_FName", AuthorFName);
            Parameters.Add("@Author_MName", AuthorMName);
            Parameters.Add("@Author_LName", AuthorLName);
            Parameters.Add("@Book_ID", Book_id);
            Parameters.Add("@Release_Date", Release_Date);
            Parameters.Add("@Book_Name", Book_Name);
            Parameters.Add("@price", price);
            Parameters.Add("@publisher", publisher);
            Parameters.Add("@Book_Status", Book_Status);
            Parameters.Add("@Book_Type", Book_Type);
            Parameters.Add("@Book_Dep", Book_Dep);
            Parameters.Add("@Book_Image", Book_Image);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetBook_Image()
        {
            string StoredProcedureName = StoredProcedures.GetBook_Image;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", 1);
            Parameters.Add("@Book_Type", "History");
            Parameters.Add("@Book_Dep", 1);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int Add_StorySection(string Sec_Name,int No_Stories,int Lib_DepID )
        {
            string StoredProcedureName = StoredProcedures.AddStorySection;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Story_Sec_Name", Sec_Name);
            Parameters.Add("@No_Of_Stories", No_Stories);
            Parameters.Add("@Story_Lib_Dep_ID", Lib_DepID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Add_Story(int Story_ID,string Story_Name,int price,string Story_Type,int Story_Dep,byte[] Story_Image)
        {
            string StoredProcedureName = StoredProcedures.AddStory;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Story_ID", Story_ID);
            Parameters.Add("@Story_Name", Story_Name);
            Parameters.Add("@Sroty_Price", price);
            Parameters.Add("@Story_Type", Story_Type);
            Parameters.Add("@Story_Dep", Story_Dep);
            Parameters.Add("@Story_Image", Story_Image);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}
