using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egypt_National_Library
{
    public class StoredProcedures
    {
        // Stored Procedures About Books //
        public static string AddBook = "spAddBook";
        public static string AddBookSection = "spAddBookSec";
        public static string GetBook_Image = "spGetBook_Image";
        public static string GetBookAvSeats = "spGetBookDepAvailableSeats";
        public static string GetSpecificBooks = "spGetSpecificBooks";
        public static string GetBookByName = "spGetBookByName";
        public static string GetBooks = "spGetBooks";

        // Stored Procedures About Stories //
        public static string AddStory = "spAddStory";
        public static string AddStorySection = "spAddStorySec";
        public static string GetStoryAvSeats = "spGetStoryDepAvailableSeats";
        public static string GetSpecificStories = "spGetSpecificStories";
        public static string GetStoryByName = "spGetStoryByName";
        public static string GetStories = "spGetStories";

        // Stored Procedures About Music_Instruments //
        public static string AddMusicSection = "";
        public static string Add_Instrument = "spAdd_Instrument";
        public static string GetMusicAvSeats = "spGetMusicDepAvailableSeates";
        public static string GetSpecificInstruments = "spGetSpecificInstruments";
        public static string GetMusical_InstrumentByName = "spGetMusicInstrumentByName";
        public static string Update_Instrument_Image = "spUpdate_Instrument_Image";
        public static string GetMusicInstruments = "spGetMusicInstruments";

        // Stored Procedures About Computers //
        public static string AddComputerSection = "";
        public static string AddComputer = "";
        public static string GetComputerByName = "spGetComputerByName";
        public static string GetSpecificComputers = "spGetSpecificComputers";
        public static string GetCmpAvSeats = "spGetComputerDepAvailableSeates";
        public static string UpdateComputerImage = "spUpdateComputerImage";
        public static string UpdateSoftwareImage = "spUpdateSoftwareImage";
        public static string GetComputerSoftwares = "spGetComputerSoftwares";
        public static string GetComputers = "spGetComputers";

        // User Stored Procedure //
        public static string UpdateUserImage = "spUpdateUserImage";
        public static string GetUserByID = "GetUserByUserID";



        public static string AddEmp = "spAddEmployee";
        public static string AddUser = "";
        public static string AddSoftware = "";
        public static string AddLibraryDepartment = "spAddLibDep";
        public static string GetEmployee_Image = "spGetEmployee_Image";
    }
}
