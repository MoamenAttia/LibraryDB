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
        public static string UpdateBookStatusAndBookUserID = "spUpdateBookStatusAndBookUserID";
        public static string UpdateBookStatusAndBookUserID_NULL = "spUpdateBookStatusAndBookUserID_NULL";
        public static string RateBook = "spRateBook";
        public static string GetAvailableBooks = "spGetAvailableBooks";
        public static string GetTopPriceBooks = "spGetTopPriceBooks";
        public static string GetTopRatedBooks = "spGetTopRatedBooks";
        public static string GetLowPriceBooks = "spGetLowPriceBooks";
        public static string GetLowRatedBooks = "spGetLowRatedBooks";
        public static string GetNotAvailableBooks = "spGetNotAvailableBooks";
        public static string GetAvailableBooksBySection = "spGetAvailableBooksBySection";
        public static string GetTopPriceBooksBySection = "spGetTopPriceBooksBySection";
        public static string GetTopRatedBooksBySection = "spGetTopRatedBooksBySection";
        public static string GetLowPriceBooksBySection = "spGetLowPriceBooksBySection";
        public static string GetLowRatedBooksBySection = "spGetLowRatedBooksBySection";
        public static string GetNotAvailableBooksBySection = "spGetNotAvailableBooksBySection";


        // Stored Procedures About Stories //
        public static string AddStory = "spAddStory";
        public static string AddStorySection = "spAddStorySec";
        public static string GetStoryAvSeats = "spGetStoryDepAvailableSeats";
        public static string GetSpecificStories = "spGetSpecificStories";
        public static string GetStoryByName = "spGetStoryByName";
        public static string GetStories = "spGetStories";
        public static string UpdateStoryStatusAndStoryUserID = "spUpdateStoryStatusAndStoryUserID";
        public static string UpdateStoryStatusAndStoryUserID_NULL = "spUpdateStoryStatusAndStoryUserID_NULL";
        public static string RateStory = "spRateStory";
        public static string GetAvailableStories = "spGetAvailableStories";
        public static string GetTopPriceStories = "spGetTopPriceStory";
        public static string GetTopRatedStories = "spGetTopRatedStories";
        public static string GetLowPriceStories = "spGetLowPriceStory";
        public static string GetLowRatedStories = "spGetLowRatedStories";
        public static string GetNotAvailableStories = "spGetNotAvailableStories";
        public static string GetAvailableStoriesBySection = "spGetAvailableStoriesBySection";
        public static string GetTopPriceStoriesBySection = "spGetTopPriceStoryBySection";
        public static string GetTopRatedStoriesBySection = "spGetTopRatedStoriesBySection";
        public static string GetLowPriceStoriesBySection = "spGetLowPriceStoryBySection";
        public static string GetLowRatedStoriesBySection = "spGetLowRatedStoriesBySection";
        public static string GetNotAvailableStoriesBySection = "spGetNotAvailableStoriesBySection";


        // Stored Procedures About Music_Instruments //
        public static string AddMusicSection = "";
        public static string Add_Instrument = "spAdd_Instrument";
        public static string GetMusicAvSeats = "spGetMusicDepAvailableSeates";
        public static string GetSpecificInstruments = "spGetSpecificInstruments";
        public static string GetMusical_InstrumentByName = "spGetMusicInstrumentByName";
        public static string Update_Instrument_Image = "spUpdate_Instrument_Image";
        public static string GetMusicInstruments = "spGetMusicInstruments";
        public static string UpdateInstrumentStatusAndInstrumentUserID = "spUpdateInstrumentStatusAndInstrumentUserID";
        public static string UpdateInstrumentStatusAndInstrumentUserID_NULL = "spUpdateInstrumentStatusAndInstrumentUserID_NULL";
        public static string RateInstrument = "spRateMusical_Instrument";
        public static string GetAvailableMusical_Instruments = "spGetAvailableMusical_Instruments";
        public static string GetNotAvailableMusical_Instruments = "spGetNotAvailableMusical_Instruments";
        public static string GetTopPriceMusical_Instruments = "spGetTopPriceMusicInstruments";
        public static string GetTopRatedMusical_Instruments = "spGetTopRatedMusicInstruments";
        public static string GetLowPriceMusical_Instruments = "spGetLowPriceMusicInstruments";
        public static string GetLowRatedMusical_Instruments = "spGetLowRatedMusicInstruments";
        public static string GetAvailableMusical_InstrumentsBySection = "spGetAvailableMusical_InstrumentsBySection";
        public static string GetNotAvailableMusical_InstrumentsBySection = "spGetNotAvailableMusical_InstrumentsBySection";
        public static string GetTopPriceMusical_InstrumentsBySection = "spGetTopPriceMusicInstrumentsBySection";
        public static string GetTopRatedMusical_InstrumentsBySection = "spGetTopRatedMusicInstrumentsBySection";
        public static string GetLowPriceMusical_InstrumentsBySection = "spGetLowPriceMusicInstrumentsBySection";
        public static string GetLowRatedMusical_InstrumentsBySection = "spGetLowRatedMusicInstrumentsBySection";




        // Stored Procedures About Computers //
        public static string AddComputerSection = "";
        public static string AddNewSoftware = "spAddNewSoftware";
        public static string AddComputer = "spAddNewComputer";
        public static string GetComputerByName = "spGetComputerByName";
        public static string GetSpecificComputers = "spGetSpecificComputers";
        public static string GetCmpAvSeats = "spGetComputerDepAvailableSeates";
        public static string UpdateComputerImage = "spUpdateComputerImage";
        public static string UpdateSoftwareImage = "spUpdateSoftwareImage";
        public static string GetComputerSoftwares = "spGetComputerSoftwares";
        public static string GetComputers = "spGetComputers";
        public static string UpdateCmpStatusAndCmpUserID = "spUpdateCmpStatusAndCmpUserID";
        public static string UpdateCmpStatusAndCmpUserID_NULL = "spUpdateCmpStatusAndCmpUserID_NULL";
        public static string RateCmp = "spRateComputer";
        public static string GetAvailableComputers = "spGetAvailableComputers";
        public static string GetNotAvailableComputers = "spGetNotAvailableComputers";
        public static string GetTopPriceComputers = "spGetTopPriceComputer";
        public static string GetTopRatedComputers = "spGetTopRatedComputer";
        public static string GetLowPriceComputers = "spGetLowPriceComputer";
        public static string GetLowRatedComputers = "spGetLowRatedComputer";
        public static string GetAvailableComputersBySection = "spGetAvailableComputersBySection";
        public static string GetNotAvailableComputersBySection = "spGetNotAvailableComputersBySection";
        public static string GetTopPriceComputersBySection = "spGetTopPriceComputerBySection";
        public static string GetTopRatedComputersBySection = "spGetTopRatedComputerBySection";
        public static string GetLowPriceComputersBySection = "spGetLowPriceComputerBySection";
        public static string GetLowRatedComputersBySection = "spGetLowRatedComputerBySection";


        // User Stored Procedure //
        public static string UpdateUserImage = "spUpdateUserImage";
        public static string GetUserByID = "GetUserByUserID";
        public static string GetMyBooks = "spGetMyBooks";
        public static string GetMyStories = "spGetMyStories";
        public static string GetMyInstruments = "spGetMyInstruments";
        public static string GetMyComputers = "spGetMyComputers";



        public static string AddEmp = "spAddEmployee";
        public static string AddUser = "";
        public static string AddSoftware = "";
        public static string AddLibraryDepartment = "spAddLibDep";
        public static string GetEmployee_Image = "spGetEmployee_Image";
        public static string UpdateAvailableSeats = "spUpdateAvailableSeats";

        //Zizo//
        public static string GetAllEmployees = "spGetEmployees";
        public static string GetEmloyeebyID = "spGetEmployeesByID";
        public static string GetEmpbyfirstname = "spGetEmployeesbyfname";
        public static string GetEmpbyFandLname = "spGetEmployeesbyflname";
        public static string GetEmpbyFullname = "spGetEmployeesbyfullname";
        public static string GetEmpbyJobtitle = "spGetEmployeesbyjobtitle";
        public static string GetEmpbyManager = "spGetEmployeesbymanagerid";
        public static string GetEmpbyAddress = "spGetEmployeesbyaddress";
        public static string GetEmpbelowSal = "spGetEmployeesbelowsal";
        public static string GetEmpequalSal = "spGetEmployeesequalsal";
        public static string GetEmpaboveSal = "spGetEmployeesabovesal";
        public static string GetEmpbelowAge = "spGetEmployeesbelowage";
        public static string GetEmpequalAge = "spGetEmployeesequalage";
        public static string GetEmpaboveAge = "spGetEmployeesaboveage";
        public static string GetAVGSalary = "spGetAvgSalary";
        public static string GetTotalSalaries = "spGetTotalSalaries";
        public static string GetAVGAge = "spGetAvgAge";
        public static string CountEmployees = "spcountallemp";
        public static string CountEmpUnderManager = "spcountempunderman";
        public static string CountEmpUnderJob = "spcountempunderjob";
        public static string AVGSalUnderJob = "spgetAvgsalariesunderJob";
        public static string AvgSalUnderManager = "spgetAvgsalariesunderManager";
        public static string TotalSalUnderManager = "spGetTotalSalariesundermanager";
        public static string AvgAgeUnderManager = "spGetAvgAgeundermanager";
        public static string TotalSalUnderJob = "spGetTotalSalariesunderJob";
        public static string AvgAgeUnderJob = "spGetAvgAgeunderJob";
        public static string GetFullNameofEmp = "spGetempfullname";
        public static string GetAddressofEmp = "spGetempAddress";
        public static string GetSalaryofEmp = "spGetempSal";
        public static string GetJobTitleofEmp = "spGetempjobtitle";
        public static string GetNeedsofEmp = "spGetempneeds";
        public static string GetAgeofEmp = "spGetempage";
        public static string GetImageofEmp = "spGetEmployee_Image";
        public static string GetManagerIDofEmp = "spGetempManagerID";
        public static string GetInfoofEmp = "spGetempinfo";
        public static string GetAllManagers = "spGetallManager";
        public static string GetAllJobs = "spGetJobs";
        public static string GetEmpIDbyname = "spGetIDbyname";
        public static string EditSalofEmloyee = "spupdateempsal";
        public static string EditPasswordofEmloyee = "spupdateemppass";
        public static string EditJobofEmloyee = "spupdateempjob";
        public static string EditAgeofEmloyee = "spupdateempage";
        public static string EditNeedsofEmloyee = "spupdateempneed";
        public static string EditAddressofEmloyee = "spupdateempAddress";
        public static string EditManagerofEmloyee = "spupdateempMID";
        public static string EditImageofEmloyee = "spupdateempimage";
        public static string Getempbyjobbelowsal = "spGetempbyjobbelowsal";
        public static string Getempbyjobabovesal = "spGetempbyjobabovesal";
        public static string Getempbyagebelowsal = "spGetempbyagebelowsal";
        public static string Getempbyageabovesal = "spGetempbyageabovesal";
        public static string SetSalaryforAge = "spSetempSalforage";
        public static string SetSalaryforJob = "spSetempSalforjob";
        public static string GetManagerName = "spGetempManagerName";
        public static string Getempbyidforlog = "spGetempbyidforlog";
        public static string FireEmp = "spFireEmp";
        //by
        public static string GetEmloyeebyIDmn = "spGetEmployeesbyIDmn";
        public static string GetEmpbyfirstnamemn = "spGetEmployeesbyfnamemn";
        public static string GetEmpbyFandLnamemn = "spGetEmployeesbyflnamemn";
        public static string GetEmpbyFullnamemn = "spGetEmployeesbyfullnamemn";
        public static string GetEmpbyJobtitlemn = "spGetEmployeesbyjobtitlemn";
        public static string GetEmpbyAddressmn = "spGetEmployeesbyaddressmn";
        public static string GetEmpbelowSalmn = "spGetEmployeesbelowsalmn";
        public static string GetEmpequalSalmn = "spGetEmployeesequalsalmn";
        public static string GetEmpaboveSalmn = "spGetEmployeesabovesalmn";
        public static string GetEmpbelowAgemn = "spGetEmployeesbelowagemn";
        public static string GetEmpequalAgemn = "spGetEmployeesequalagemn";
        public static string GetEmpaboveAgemn = "spGetEmployeesaboveagemn";
        //

        public static string GetFullNameofEmpmn = "spGetempfullnamemn";
        public static string GetAddressofEmpmn = "spGetempAddressmn";
        public static string GetSalaryofEmpmn = "spGetempSalmn";
        public static string GetJobTitleofEmpmn = "spGetempjobtitlemn";
        public static string GetNeedsofEmpmn = "spGetempneedsmn";
        public static string GetAgeofEmpmn = "spGetempagemn";
        public static string GetInfoofEmpmn = "spGetempinfomn";
        public static string GetEmployee_Imagemnmn = "spGetEmployee_Imagemn";

        //
        public static string GetEmpIDbynamemn = "spGetIDbynamemn";

    }
}
