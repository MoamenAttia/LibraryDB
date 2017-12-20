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
        public int UpdateUserImage(byte[] image,int User_ID)
        {
            string StoredProcedureName = StoredProcedures.UpdateUserImage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_Image", image);
            Parameters.Add("@User_ID", User_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetUserByID(int User_ID)
        {
            string StoredProcedureName = StoredProcedures.GetUserByID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID", User_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetMyBooks(int User_ID)
        {
            string StoredProcedureName = StoredProcedures.GetMyBooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID", User_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetMyStories(int User_ID)
        {
            string StoredProcedureName = StoredProcedures.GetMyStories;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID", User_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetMyInstruments(int User_ID)
        {
            string StoredProcedureName = StoredProcedures.GetMyInstruments;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID", User_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetMyComputers(int User_ID)
        {
            string StoredProcedureName = StoredProcedures.GetMyComputers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID", User_ID);
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
        public int UpdateBookStatusAndBookUserID(int Book_User_ID, int Book_ID, string Book_Type, int Book_Dep,string Status)
        {
            string StoredProcedureName = StoredProcedures.UpdateBookStatusAndBookUserID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID",Book_User_ID);
            Parameters.Add("@Book_ID",Book_ID);
            Parameters.Add("@Book_Type",Book_Type);
            Parameters.Add("@Book_Dep",Book_Dep);
            Parameters.Add("@Status",Status);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateBookStatusAndBookUserID_NULL( int Book_ID, string Book_Type, int Book_Dep, string Status)
        {
            string StoredProcedureName = StoredProcedures.UpdateBookStatusAndBookUserID_NULL;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", Book_ID);
            Parameters.Add("@Book_Type", Book_Type);
            Parameters.Add("@Book_Dep", Book_Dep);
            Parameters.Add("@Status", Status);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        /// 
        public int UpdateStoryStatusAndStoryUserID(int Story_User_ID, int Story_ID, string Story_Type, int Story_Dep, string Status)
        {
            string StoredProcedureName = StoredProcedures.UpdateStoryStatusAndStoryUserID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID", Story_User_ID);
            Parameters.Add("@Story_ID", Story_ID);
            Parameters.Add("@Story_Type", Story_Type);
            Parameters.Add("@Story_Dep", Story_Dep);
            Parameters.Add("@Status", Status);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateStoryStatusAndStoryUserID_NULL(int Story_ID, string Story_Type, int Story_Dep, string Status)
        {
            string StoredProcedureName = StoredProcedures.UpdateStoryStatusAndStoryUserID_NULL;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Story_ID", Story_ID);
            Parameters.Add("@Story_Type", Story_Type);
            Parameters.Add("@Story_Dep", Story_Dep);
            Parameters.Add("@Status", Status);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        /// 
        /// 
        public int UpdateInstrumentStatusAndInstrumentUserID(int Instrument_User_ID, int Instrument_ID, string Instrument_Type, int Instrument_Dep, string Status)
        {
            string StoredProcedureName = StoredProcedures.UpdateInstrumentStatusAndInstrumentUserID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID", Instrument_User_ID);
            Parameters.Add("@Instrument_ID", Instrument_ID);
            Parameters.Add("@Instrument_Type", Instrument_Type);
            Parameters.Add("@Instrument_Dep", Instrument_Dep);
            Parameters.Add("@Status", Status);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateInstrumentStatusAndInstrumentUserID_NULL(int Instrument_ID, string Instrument_Type, int Instrument_Dep, string Status)
        {
            string StoredProcedureName = StoredProcedures.UpdateInstrumentStatusAndInstrumentUserID_NULL;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Instrument_ID", Instrument_ID);
            Parameters.Add("@Instrument_Type", Instrument_Type);
            Parameters.Add("@Instrument_Dep", Instrument_Dep);
            Parameters.Add("@Status", Status);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        /// 
        /// 
        public int UpdateCmpStatusAndCmpUserID(int Cmp_User_ID, int Cmp_ID, string Cmp_Type, int Cmp_Dep, string Status)
        {
            string StoredProcedureName = StoredProcedures.UpdateCmpStatusAndCmpUserID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_ID", Cmp_User_ID);
            Parameters.Add("@Cmp_ID", Cmp_ID);
            Parameters.Add("@Cmp_Type", Cmp_Type);
            Parameters.Add("@Cmp_Dep", Cmp_Dep);
            Parameters.Add("@Status", Status);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateCmpStatusAndCmpUserID_NULL(int Cmp_ID, string Cmp_Type, int Cmp_Dep, string Status)
        {
            string StoredProcedureName = StoredProcedures.UpdateCmpStatusAndCmpUserID_NULL;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Cmp_ID", Cmp_ID);
            Parameters.Add("@Cmp_Type", Cmp_Type);
            Parameters.Add("@Cmp_Dep", Cmp_Dep);
            Parameters.Add("@Status", Status);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        /// 
        public int RateBook(int Book_ID, string Book_Type, int Book_Dep, int Rate)
        {
            string StoredProcedureName = StoredProcedures.RateBook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Book_ID", Book_ID);
            Parameters.Add("@Book_Type", Book_Type);
            Parameters.Add("@Book_Dep", Book_Dep);
            Parameters.Add("@Rate", Rate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///
 
        public int RateStory(int Story_ID, string Story_Type, int Story_Dep, int Rate)
        {
            string StoredProcedureName = StoredProcedures.RateStory;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Story_ID", Story_ID);
            Parameters.Add("@Story_Type", Story_Type);
            Parameters.Add("@Story_Dep", Story_Dep);
            Parameters.Add("@Rate", Rate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///
        public int RateCmp(int Cmp_ID, string Cmp_Type, int Cmp_Dep, int Rate)
        {
            string StoredProcedureName = StoredProcedures.RateCmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Cmp_ID", Cmp_ID);
            Parameters.Add("@Cmp_Type", Cmp_Type);
            Parameters.Add("@Cmp_Dep", Cmp_Dep);
            Parameters.Add("@Rate", Rate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int RateInstrument(int Instrument_ID, string Instrument_Type, int Instrument_Dep, int Rate)
        {
            string StoredProcedureName = StoredProcedures.RateInstrument;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Instrumentp_ID", Instrument_ID);
            Parameters.Add("@Instrument_Type", Instrument_Type);
            Parameters.Add("@Instrument_Dep", Instrument_Dep);
            Parameters.Add("@Rate", Rate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    ///
    /// 



    /*Aziz Part*/
    //emp
    //Employee
    public int Add_Employee
            (string Fname, string Mname, string Lname,
             int Salary, int ID, string Pass
            , int Age, string Job, string Needs, string Address,
            int ManagerId, byte[] Emp_Image)
        {
            string StoredProcedureName = StoredProcedures.AddEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@MName", Mname);
            Parameters.Add("@LName", Lname);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Emp_ID", ID);
            Parameters.Add("@Password", Pass);
            Parameters.Add("@Age", Age);
            Parameters.Add("@JobTitle", Job);
            Parameters.Add("@Needs", Needs);
            Parameters.Add("@Address", Address);
            Parameters.Add("@Manager_ID", ManagerId);
            Parameters.Add("@Employee_Image", Emp_Image);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable Get_All_Emp()
        {
            string StoredProcedureName = StoredProcedures.GetAllEmployees;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_ID(int ID)
        {
            string StoredProcedureName = StoredProcedures.GetEmloyeebyID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Get_Employee_by_fname(string fname)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyfirstname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fn", fname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_flname(string fname, string lname)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyFandLname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fn", fname);
            Parameters.Add("@ln", lname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_fullname(string fname, string mname, string lname)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyFullname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fn", fname);
            Parameters.Add("@mn", mname);
            Parameters.Add("@ln", lname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable Get_Employee_by_Job(string job)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyJobtitle;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@jti", job);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_Manager(int mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_Address(string address)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ad", address);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_below_sal(int sal)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbelowSal;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_equal_sal(int sal)
        {
            string StoredProcedureName = StoredProcedures.GetEmpequalSal;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_above_sal(int sal)
        {
            string StoredProcedureName = StoredProcedures.GetEmpaboveSal;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_below_age(int age)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbelowAge;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@a", age);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_equal_age(int age)
        {
            string StoredProcedureName = StoredProcedures.GetEmpequalAge;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@a", age);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_above_age(int age)
        {
            string StoredProcedureName = StoredProcedures.GetEmpaboveAge;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@a", age);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_AVG_Sal()
        {
            string StoredProcedureName = StoredProcedures.GetAVGSalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Total_Sal()
        {
            string StoredProcedureName = StoredProcedures.GetTotalSalaries;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_AVG_Age()
        {
            string StoredProcedureName = StoredProcedures.GetAVGAge;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Count_Employees()
        {
            string StoredProcedureName = StoredProcedures.CountEmployees;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Count_Employees_under_Manager(int mid)
        {
            string StoredProcedureName = StoredProcedures.CountEmpUnderManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Count_Employees_under_Job(string jti)
        {
            string StoredProcedureName = StoredProcedures.CountEmpUnderJob;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@jti", jti);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable AVG_Sal_Under_Manager(int mid)
        {
            string StoredProcedureName = StoredProcedures.AvgSalUnderManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Total_Sal_Under_Manager(int mid)
        {
            string StoredProcedureName = StoredProcedures.TotalSalUnderManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable AVG_Age_Under_Manager(int mid)
        {
            string StoredProcedureName = StoredProcedures.AvgAgeUnderManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Total_Sal_Under_Job(string job)
        {
            string StoredProcedureName = StoredProcedures.TotalSalUnderJob;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@jti", job);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable AVG_Age_Under_Job(string job)
        {
            string StoredProcedureName = StoredProcedures.AvgAgeUnderJob;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@jti", job);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable AVG_Sal_Under_Job(string jti)
        {
            string StoredProcedureName = StoredProcedures.AVGSalUnderJob;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@jti", jti);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable Get_Emp_Name(int id)
        {
            string StoredProcedureName = StoredProcedures.GetFullNameofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Address(int id)
        {
            string StoredProcedureName = StoredProcedures.GetAddressofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Salary(int id)
        {
            string StoredProcedureName = StoredProcedures.GetSalaryofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Job(int id)
        {
            string StoredProcedureName = StoredProcedures.GetJobTitleofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Needs(int id)
        {
            string StoredProcedureName = StoredProcedures.GetNeedsofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Age(int id)
        {
            string StoredProcedureName = StoredProcedures.GetAgeofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Image(int id)
        {
            string StoredProcedureName = StoredProcedures.GetImageofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_ManagerID(int id)
        {
            string StoredProcedureName = StoredProcedures.GetManagerIDofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Info(int id)
        {
            string StoredProcedureName = StoredProcedures.GetInfoofEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_All_Managers()
        {
            string StoredProcedureName = StoredProcedures.GetAllManagers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_All_Jobs()
        {
            string StoredProcedureName = StoredProcedures.GetAllJobs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_ID_byname(string fname, string mname, string lname)
        {
            string StoredProcedureName = StoredProcedures.GetEmpIDbyname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fname", fname);
            Parameters.Add("@mname", mname);
            Parameters.Add("@lname", lname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Edit_Emp_Sal(int id, int sal)
        {
            string StoredProcedureName = StoredProcedures.EditSalofEmloyee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Edit_Emp_Pass(int id, string pass)
        {
            string StoredProcedureName = StoredProcedures.EditPasswordofEmloyee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@Pass", pass);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Edit_Emp_Job(int id, string job)
        {
            string StoredProcedureName = StoredProcedures.EditJobofEmloyee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@j", job);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Edit_Emp_Age()//updates all ages of imp at 1/1
        {
            string StoredProcedureName = StoredProcedures.EditAgeofEmloyee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Edit_Emp_Needs(int id, string need)
        {
            string StoredProcedureName = StoredProcedures.EditNeedsofEmloyee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@n", need);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Edit_Emp_Address(int id, string adres)
        {
            string StoredProcedureName = StoredProcedures.EditAddressofEmloyee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@ad", adres);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Edit_Emp_Manager(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.EditManagerofEmloyee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Edit_Emp_Image(int id, byte[] Emp_Image)
        {
            string StoredProcedureName = StoredProcedures.EditImageofEmloyee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@im", Emp_Image);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_by_Job_below_Sal(string job, int sal)
        {
            string StoredProcedureName = StoredProcedures.Getempbyjobbelowsal;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@j", job);
            Parameters.Add("@sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_by_Job_above_Sal(string job, int sal)
        {
            string StoredProcedureName = StoredProcedures.Getempbyjobabovesal;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@j", job);
            Parameters.Add("@sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_by_Age_below_Sal(int age, int sal)
        {
            string StoredProcedureName = StoredProcedures.Getempbyagebelowsal;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@age", age);
            Parameters.Add("@sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_by_Age_above_Sal(int age, int sal)
        {
            string StoredProcedureName = StoredProcedures.Getempbyageabovesal;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@age", age);
            Parameters.Add("@sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Set_Salary_for_Age(int age, int sal)
        {
            string StoredProcedureName = StoredProcedures.SetSalaryforAge;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@age", age);
            Parameters.Add("@sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Set_Salary_for_Job(string job, int sal)
        {
            string StoredProcedureName = StoredProcedures.SetSalaryforJob;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@j", job);
            Parameters.Add("@sal", sal);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Manager_Name(int id)
        {
            string StoredProcedureName = StoredProcedures.GetManagerName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_ID_forlog(int id)
        {
            string StoredProcedureName = StoredProcedures.Getempbyidforlog;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Fire_Emp(int id)
        {
            string StoredProcedureName = StoredProcedures.FireEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //by
        public DataTable Get_Employee_by_IDmn(int ID, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmloyeebyIDmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", ID);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Get_Employee_by_fnamemn(string fname, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyfirstnamemn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fn", fname);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_flnamemn(string fname, string lname, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyFandLnamemn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fn", fname);
            Parameters.Add("@ln", lname);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_fullnamemn(string fname, string mname, string lname, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyFullnamemn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fn", fname);
            Parameters.Add("@mn", mname);
            Parameters.Add("@ln", lname);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable Get_Employee_by_Jobmn(string job, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyJobtitlemn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@jti", job);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_by_Addressmn(string address, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbyAddressmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ad", address);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_below_salmn(int sal, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbelowSalmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sal", sal);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_equal_salmn(int sal, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpequalSalmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sal", sal);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_above_salmn(int sal, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpaboveSalmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Sal", sal);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_below_agemn(int age, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpbelowAgemn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@a", age);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_equal_agemn(int age, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpequalAgemn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@a", age);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Employee_above_agemn(int age, int Mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpaboveAgemn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@a", age);
            Parameters.Add("@mid", Mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_ID_bynamemn(string fname, string mname, string lname, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmpIDbynamemn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fname", fname);
            Parameters.Add("@mname", mname);
            Parameters.Add("@lname", lname);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //

        public DataTable Get_Emp_Namemn(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetFullNameofEmpmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Addressmn(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetAddressofEmpmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Salarymn(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetSalaryofEmpmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Jobmn(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetJobTitleofEmpmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Needsmn(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetNeedsofEmpmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Agemn(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetAgeofEmpmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Imagemn(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetEmployee_Imagemnmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Get_Emp_Infomn(int id, int mid)
        {
            string StoredProcedureName = StoredProcedures.GetInfoofEmpmn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@mid", mid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

    }
}
