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
        public DataTable GetBook_Image(int id , string type,int libdep)
        {
            string StoredProcedureName = StoredProcedures.GetBook_Image;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", id);
            Parameters.Add("@Book_Type", type);
            Parameters.Add("@Book_Dep", libdep);

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
        public int Update_Instrument_Image(byte[] Instrument_Image,int Instrument_ID, int Instrument_Dep, string Instrument_Type )
        {
            string StoredProcedureName = StoredProcedures.Update_Instrument_Image;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Ins_Image", Instrument_Image);
            Parameters.Add("@Ins_ID", Instrument_ID);
            Parameters.Add("@Ins_Dep", Instrument_Dep);
            Parameters.Add("@Ins_Type", Instrument_Type);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Add_Instrument(int Instrument_ID, string Instrument_Name, int Instrument_Price, string Instrument_Type, int Instrument_Dep, byte[] Instrument_Image)
        {
            string StoredProcedureName = StoredProcedures.Add_Instrument;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
           
            Parameters.Add("@Musical_Ins_ID", Instrument_ID);
            Parameters.Add("@Musical_Ins_Name", Instrument_Name);
            Parameters.Add("@Musical_Ins_Price", Instrument_Price);
            Parameters.Add("@Musical_Ins_Type", Instrument_Type);
            Parameters.Add("@Musical_Ins_Dep", Instrument_Dep);
            Parameters.Add("@Instrument_Image", Instrument_Image);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetSpecificBooks(string Type,int LibDepID)
        {
            string StoredProcedureName = StoredProcedures.GetSpecificBooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_Type", Type);
            Parameters.Add("@Book_Dep", LibDepID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetSpecificStories(string Type, int LibDepID)
        {
            string StoredProcedureName = StoredProcedures.GetSpecificStories;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Story_Type", Type);
            Parameters.Add("@Story_Dep", LibDepID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetSpecificInstruments(string Type, int LibDepID)
        {
            string StoredProcedureName = StoredProcedures.GetSpecificInstruments;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Musical_Ins_Type", Type);
            Parameters.Add("@Musical_Ins_Dep", LibDepID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetSpecificComputers(string Type, int LibDepID)
        {
            string StoredProcedureName = StoredProcedures.GetSpecificComputers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Cmp_Type", Type);
            Parameters.Add("@Cmp_Dep", LibDepID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int UpdateComputerImage(int Cmp_ID,int Cmp_Dep,string Cmp_Type,byte[] image)
        {
            string StoredProcedureName = StoredProcedures.UpdateComputerImage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Computer_Image", image);
            Parameters.Add("@CmpID", Cmp_ID);
            Parameters.Add("@CmpDep", Cmp_Dep);
            Parameters.Add("@CmpType", Cmp_Type);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetBookByName(int Book_ID,int LibDep,string Book_Type)
        {
            string StoredProcedureName = StoredProcedures.GetBookByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", Book_ID);
            Parameters.Add("@Book_Type", Book_Type);
            Parameters.Add("@Book_Dep", LibDep);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetStoryByName(int StoryID, int StoryDep, string StoryType)
        {
            string StoredProcedureName = StoredProcedures.GetStoryByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Story_ID", StoryID);
            Parameters.Add("@Story_Type", StoryType);
            Parameters.Add("@Story_Dep", StoryDep);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetMusical_InstrumentByName(int Musical_InstrumentID, int Musical_InstrumentDep, string Musical_InstrumentType)
        {
            string StoredProcedureName = StoredProcedures.GetMusical_InstrumentByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Musical_Ins_ID", Musical_InstrumentID);
            Parameters.Add("@Musical_Ins_Type", Musical_InstrumentType);
            Parameters.Add("@Musical_Ins_Dep", Musical_InstrumentDep);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetComputerByName(int CmpID, int CmpDep, string CmpType)
        {
            string StoredProcedureName = StoredProcedures.GetComputerByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Cmp_ID", CmpID);
            Parameters.Add("@Cmp_Type", CmpType);
            Parameters.Add("@Cmp_Dep", CmpDep);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int UpdateSoftwareImage(byte[] image , string SoftwareName,int CmpDep ,string CmpType,int CmpID)
        {
            string StoredProcedureName = StoredProcedures.UpdateSoftwareImage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Computer_Image", image);
            Parameters.Add("@Software", SoftwareName);
            Parameters.Add("@CmpDep", CmpDep);
            Parameters.Add("@CmpType", CmpType);
            Parameters.Add ("@CmpID", CmpID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetComputerSoftwares(int CmpID,int CmpDep,string CmpType)
        {
            string StoredProcedureName = StoredProcedures.GetComputerSoftwares;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Cmp_ID", CmpID);
            Parameters.Add("@Cmp_Dep", CmpDep);
            Parameters.Add("@Cmp_Type", CmpType);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetAllBooks() { string StoredProcedureName = StoredProcedures.GetBooks; return dbMan.ExecuteReader(StoredProcedureName, null); }
        public DataTable GetAllStories() { string StoredProcedureName = StoredProcedures.GetStories; return dbMan.ExecuteReader(StoredProcedureName, null); }
        public DataTable GetAllMusicInstruments() { string StoredProcedureName = StoredProcedures.GetMusicInstruments; return dbMan.ExecuteReader(StoredProcedureName, null); }
        public DataTable GetAllComputers() { string StoredProcedureName = StoredProcedures.GetComputers; return dbMan.ExecuteReader(StoredProcedureName, null); }

        public DataTable GetBookDepAvailableSeats() { string StoredProcedureName = StoredProcedures.GetBookAvSeats; return dbMan.ExecuteReader(StoredProcedureName, null);  }
        public DataTable GetStoryDepAvailableSeats() { string StoredProcedureName = StoredProcedures.GetStoryAvSeats; return dbMan.ExecuteReader(StoredProcedureName, null); }
        public DataTable GetMusicDepAvailableSeats() { string StoredProcedureName = StoredProcedures.GetMusicAvSeats; return dbMan.ExecuteReader(StoredProcedureName, null); }
        public DataTable GetCmpDepAvailableSeats() { string StoredProcedureName = StoredProcedures.GetCmpAvSeats; return dbMan.ExecuteReader(StoredProcedureName, null); }
        
    }
}
