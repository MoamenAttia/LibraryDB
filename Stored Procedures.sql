Use [Egypt National Library]
GO

Create Procedure spAddEmployee
@Fname nvarchar(50),
@MName nvarchar(50),
@LName nvarchar(50),
@Salary int,
@Emp_ID int,
@Password nvarchar(10),
@Age int,
@JobTitle nvarchar(50),
@Address nvarchar(50),
@Manager_ID int,
@Employee_Image image
As
Begin 
	Insert Into Employee (Fname,Mname,Lname,Salary,Emp_ID,[Password],Age,Job_Title,[Address],Manager_ID,Employee_Image) values (@Fname,@MName,@LName,@Salary,@Emp_ID,@Password,@Age,@JobTitle,@Address,@Manager_ID,@Employee_Image);
End
GO

Create procedure spAddLibDep
@Lib_Dep_ID int,
@Lib_Dep_Name nvarchar(30),
@Construction_Date date,
@Services_Can_Provide nvarchar(50),
@Available_Seats int,
@Supervisor_ID int
As
Begin 
	Insert Into Library_Department(Lib_Dep_ID,Lib_Dep_Name,Construction_Date,Services_Can_Provide,Available_Seats,Supervisor_ID) values (@Lib_Dep_ID,@Lib_Dep_Name,@Construction_Date,@Services_Can_Provide,@Available_Seats,@Supervisor_ID);
End
GO

Create procedure spAddBookSec
@Book_Sec_Name	nvarchar(30),
@No_Of_Books int,
@Book_Lib_Dep_ID int
As
Begin
	Insert Into Book_Section ( Book_Sec_Name , No_Of_Books , Book_Lib_Dep_ID ) values ( @Book_Sec_Name , @No_Of_Books , @Book_Lib_Dep_ID );
End
GO


Create Procedure spAddBook
@Author_FName nvarchar(30),
@Author_MName nvarchar(30),
@Author_LName nvarchar(30),
@Book_ID int,
@Book_Rate int,
@Release_Date date,
@Book_Name nvarchar(30),
@price int,
@publisher nvarchar(30),
@Book_Status nvarchar(10),
@Time_To_Be_Deliver date,
@Kind_Of_Use nvarchar(20),
@Book_User_ID int,
@Book_Type nvarchar(30),
@Book_Dep int,
@Book_Image image
As
Begin
	Insert Into Book( Author_FName , Author_MName , Author_LName , Book_ID , Book_Rate , Release_Date , Book_Name , price , publisher , Book_Status , Time_To_Be_Deliver , Kind_Of_Use , Book_User_ID , Book_Type , Book_Dep , Book_Image) 
	values ( @Author_FName , @Author_MName , @Author_LName , @Book_ID , @Book_Rate , @Release_Date , @Book_Name , @price , @publisher , @Book_Status , @Time_To_Be_Deliver , @Kind_Of_Use , @Book_User_ID , @Book_Type , @Book_Dep , @Book_Image  );
End
GO


Create Procedure spAddStorySec
@Story_Sec_Name nvarchar(30),
@No_Of_Stories int,
@Story_Lib_Dep_ID int
As
Begin
	Insert Into Story_Section ( Story_Sec_Name , No_Of_Stories , Story_Lib_Dep_ID  ) values ( @Story_Sec_Name , @No_Of_Stories , @Story_Lib_Dep_ID );
End
GO

Create Procedure spAddStory
@Story_ID int,
@Story_Name nvarchar(50),
@Sroty_Price int ,
@recently_read int ,
@Story_Type nvarchar(30),
@Story_Dep int ,
@Story_User_ID int ,
@Story_Image image
As
Begin
	Insert Into Story ( Story_ID , Story_Name , Sroty_Price , recently_read , Story_Type , Story_Dep , Story_User_ID , Story_Image )
			   values ( @Story_ID , @Story_Name , @Sroty_Price , @recently_read , @Story_Type , @Story_Dep , @Story_User_ID , @Story_Image );
End
GO
