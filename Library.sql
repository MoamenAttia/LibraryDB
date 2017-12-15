Create database [Egypt National Library]
GO
use [Egypt National Library]
------------Table Creation-----------------
create table Employee
(
Fname nvarchar(50) not null,
Mname nvarchar(50) not null,
Lname nvarchar(50) not null,
Salary int not null,
Emp_ID int primary key,
Password nvarchar(10) not null,
Age int,
Job_Title nvarchar(50) not null,
Needs nvarchar(max),
Address nvarchar(50),
Manager_ID int foreign key references Employee(Emp_Id),
Employee_Image image,
);

create table Library_Department
(
Lib_Dep_ID int primary key,
Lib_Dep_Name nvarchar (30),
Construction_Date nvarchar(10) not null,
Services_Can_Provide nvarchar (max) not null,
Available_Seats int not null,
Supervisor_ID int foreign key references Employee(Emp_ID)
);


create table [User]
(
User_FName nvarchar(30) not null,
User_MName nvarchar(30) not null,
User_LName nvarchar(30) not null,
User_Rate int,
User_ID int primary key not null,
User_Password nvarchar(10) not null,
User_Image image,
);


create table Story_Section
(
Story_Sec_Name nvarchar (30),
No_Of_Stories int not null,
Story_Lib_Dep_ID int foreign key references Library_Department(Lib_Dep_ID) not null,
Primary key (Story_Sec_Name,Story_Lib_Dep_ID) 
);

create table Music_Section
(
Music_Sec_Name nvarchar (30),
No_Of_Instruments int not null,
Music_Lib_Dep_ID int foreign key references Library_Department(Lib_Dep_ID) not null,
Primary key(Music_Sec_Name,Music_Lib_Dep_ID)
);

create table Computer_Section
(
Cmp_Sec_Name nvarchar (30),
No_Of_Computers int not null,
Cmp_Lib_Dep_ID int foreign key references Library_Department(Lib_Dep_ID) not null,
Primary key(Cmp_Sec_Name,Cmp_Lib_Dep_ID)
);

create table Book_Section
(
Book_Sec_Name nvarchar (30),
No_Of_Books int not null,
Book_Lib_Dep_ID int foreign key references Library_Department(Lib_Dep_ID) not null,
Primary key(Book_Sec_Name,Book_Lib_Dep_ID)
);


create table Story
(
Story_ID int,
Story_Name nvarchar(50) not null,
Sroty_Price int not null,
recently_read int not null,
Story_Type nvarchar(30),
Story_Dep int ,
Story_User_ID int foreign key references [User]( User_ID),
Story_Image image,
foreign key(Story_Type,Story_Dep) references Story_Section(Story_Sec_Name,Story_Lib_Dep_ID),
Primary key (Story_ID,Story_Type,Story_Dep)
);


create table Musical_Instrument
(
Musical_Ins_ID int  not null,
Musical_Ins_Name nvarchar(50) not null,	
Musical_Ins_Status nvarchar(10) not null,
Musical_Ins_price int not null,
Musical_Ins_User_ID int foreign key references [User](User_ID),
Musical_Ins_Type nvarchar(30) not null,
Musical_Ins_Dep int not null,
Instrument_Image image,
foreign key(Musical_Ins_Type,Musical_Ins_Dep) references Music_Section(Music_Sec_Name,Music_Lib_Dep_ID),
Primary key (Musical_Ins_ID,Musical_Ins_Type,Musical_Ins_Dep)

);

create table Computer
(
Cmp_ID int,
Operating_System nvarchar(30) not null,
Cmp_Status nvarchar(10) not null,
Cmp_Price int not null, 
Cmp_User_ID int foreign key references [User]( User_ID),
Cmp_Type nvarchar(30),
Cmp_Dep int ,
foreign key(Cmp_Type,Cmp_Dep) references Computer_Section(Cmp_Sec_Name,Cmp_Lib_Dep_ID),
Primary key (Cmp_ID,Cmp_Type,Cmp_Dep)
);

create table Cmp_Software
(
Software nvarchar(30),
Cmp_ID int,
Cmp_Type nvarchar(30),
Cmp_Dep int ,
foreign key(Cmp_ID,Cmp_Type,Cmp_Dep) references Computer(Cmp_ID,Cmp_Type,Cmp_Dep),
Primary key (Cmp_ID,Cmp_Type,Cmp_Dep,Software)
);


create table Book
(
Author_FName nvarchar(30) not null,
Author_MName nvarchar(30) not null,
Author_LName nvarchar(30) not null,
Book_ID int,
Book_Rate int,
Release_Date nvarchar(10),
Book_Name nvarchar(30) not null,
price int not null,
publisher nvarchar(30) not null,
Book_Status nvarchar(20) not null,--kind of use
Time_To_Be_Deliver nvarchar(10),
Book_User_ID int foreign key references [User]( User_ID),
Book_Type nvarchar(30),
Book_Dep int ,
Book_Image image,
foreign key(Book_Type,Book_Dep) references Book_Section(Book_Sec_Name,Book_Lib_Dep_ID),
Primary key (Book_ID,Book_Type,Book_Dep)
);

