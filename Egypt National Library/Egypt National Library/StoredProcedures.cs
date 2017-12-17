﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egypt_National_Library
{
    public class StoredProcedures
    {
        public static string AddEmp = "spAddEmployee";
        public static string AddBook = "spAddBook";
        public static string AddMusicInstrument = "";
        public static string AddStory = "spAddStory";
        public static string AddUser = "";
        public static string AddBookSection = "spAddBookSec";
        public static string AddMusicSection = "";
        public static string AddComputerSection = "";
        public static string AddStorySection = "spAddStorySec";
        public static string AddComputer = "";
        public static string AddSoftware = "";
        public static string AddLibraryDepartment = "spAddLibDep";
        public static string GetBook_Image = "spGetBook_Image";
        public static string GetEmployee_Image = "spGetEmployee_Image";
        public static string Update_Instrument_Image = "spUpdate_Instrument_Image";
        public static string Add_Instrument = "spAdd_Instrument";
        public static string GetBookAvSeats = "spGetBookDepAvailableSeats";
        public static string GetStoryAvSeats = "spGetStoryDepAvailableSeats";
        public static string GetMusicAvSeats = "spGetMusicDepAvailableSeates";
        public static string GetCmpAvSeats = "spGetComputerDepAvailableSeates";
        public static string GetSpecificBooks = "spGetSpecificBooks";
        public static string GetSpecificStories = "spGetSpecificStories";
        public static string GetSpecificInstruments = "spGetSpecificInstruments";
        public static string GetSpecificComputers = "spGetSpecificComputers";
        public static string UpdateComputerImage = "spUpdateComputerImage";
        public static string GetBookByName = "spGetBookByName";
    }
}
