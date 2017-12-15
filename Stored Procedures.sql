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
@Needs nvarchar(max),
@Address nvarchar(50),
@Manager_ID int,
@Employee_Image image
As
Begin 
	Insert Into Employee (Fname,Mname,Lname,Salary,Emp_ID,[Password],Age,Job_Title,Needs,[Address],Manager_ID,Employee_Image) values (@Fname,@MName,@LName,@Salary,@Emp_ID,@Password,@Age,@JobTitle,@Needs,@Address,@Manager_ID,@Employee_Image);
End
GO

Create procedure spAddLibDep
@Lib_Dep_ID int,
@Lib_Dep_Name nvarchar(30),
@Construction_Date nvarchar(10),
@Services_Can_Provide nvarchar(max),
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
@Release_Date nvarchar(10),
@Book_Name nvarchar(30),
@price int,
@publisher nvarchar(30),
@Book_Status nvarchar(20),
@Book_Type nvarchar(30),
@Book_Dep int,
@Book_Image image
As
Begin
	Insert Into Book( Author_FName , Author_MName , Author_LName , Book_ID  , Release_Date , Book_Name , price , publisher , Book_Status  , Book_Type , Book_Dep , Book_Image) 
	values ( @Author_FName , @Author_MName , @Author_LName , @Book_ID   , @Release_Date , @Book_Name , @price , @publisher , @Book_Status  , @Book_Type , @Book_Dep , @Book_Image  );
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
@Story_Type nvarchar(30),
@Story_Dep int ,
@Story_Image image
As
Begin
	Insert Into Story ( Story_ID , Story_Name , Sroty_Price  , Story_Type , Story_Dep  , Story_Image,recently_read )
			   values ( @Story_ID , @Story_Name , @Sroty_Price , @Story_Type , @Story_Dep , @Story_Image ,0);
End
GO

Create Procedure spGetBooks
As
Begin
	Select * from Book
End
GO

Create Procedure spGetStories
As
Begin
	Select * From Story;
End
GO

Create Procedure spGetBookSec
As
Begin
	Select * From Book_Section;
End
GO

Create Procedure spGetStorySec
As
Begin
	Select * From Story_Section;
End
GO

Create Procedure spGetLibDepartments
As
Begin
	Select * From Library_Department;
End
GO

Create Procedure spGetEmployees
As
Begin
	Select * From Employee;
End
GO

Create Procedure spGetBook_Image
@Book_ID int,
@Book_Type nvarchar(30),
@Book_Dep int
As
Begin
	Select Book_Image 
	From Book 
	where 
		Book_ID = @Book_ID And
		Book_Type =  @Book_Type And
		Book_Dep = @Book_Dep
End
GO

Create Procedure spGetEmployee_Image
@Emp_ID int
As
Begin
	Select Employee_Image 
	From Employee
	where Emp_ID = @Emp_ID
End
GO

