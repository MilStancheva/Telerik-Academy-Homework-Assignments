--Task 1
--Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
-- - Insert few records for testing.
-- - Write a stored procedure that selects the full names of all persons.
---------------------------------------------
USE Accounts

GO

CREATE TABLE Persons
(
Id int PRIMARY KEY IDENTITY,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
SSN char(9),
CONSTRAINT [SSN_isNumber] 
    CHECK ([SSN] LIKE REPLICATE('[0-9]', 10))
)

GO
----------------------------------------------

USE Accounts

GO

CREATE TABLE Accounts
(
Id int PRIMARY KEY IDENTITY,
PersonId int NOT NULL,
Balance money NOT NULL,
FOREIGN KEY (PersonId) REFERENCES Persons(Id)
)

GO
------------------------------------------------

USE Accounts
GO

INSERT INTO Persons([FirstName], [LastName], [SSN])
VALUES
('Ivan', 'Ivanov', '123456780'),
('George', 'Enchev', '123456770'),
('Anna', 'Petkova', '123456890'),
('Kristina', 'Ilieva', '123457890');

----------------------------------------------

USE Accounts
GO

INSERT INTO Accounts([PersonId], [Balance])
VALUES
(7, 500),
(8, 1200),
(9, 3689),
(10, 12),
(11, 67800),
(12, 56),
(13, 2345);

----------------------------------------------


USE Accounts
GO

CREATE PROCEDURE dbo.sp_GetFullNames
AS
    SELECT [FirstName] + ' ' + [LastName] AS [Full Name] FROM Persons;
GO
EXEC sp_GetFullNames;
-- EXEC dbo.sp_GetFullNames;
GO

-------------------------------------------------

-- 2. Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

CREATE PROC sp_GetPersonsWithMoreMoney(@number money) 
AS 
SELECT p.[FirstName] + ' ' + p.[LastName] AS [Full Name]
FROM Persons p
JOIN Accounts a 
ON p.Id = a.PersonId
WHERE a.Balance > @number
GO

-------------------------------------------------
USE Accounts
GO

EXEC sp_GetPersonsWithMoreMoney 3000;
GO

-- 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
-- It should calculate and return the new sum.
-- Write a SELECT to test whether the function works as expected.

USE Accounts
GO

CREATE FUNCTION ufn_CalculateYearlyInterestRate(@sum money, @yearlyInterestRate money, @numberOfMonths int)
RETURNS money
AS 
BEGIN
 RETURN @sum + (@sum * @yearlyInterestRate * @numberOfMonths)
END
-------------------------------------------------

USE Accounts
GO

DECLARE @newSum money;   

EXEC @newSum = dbo.ufn_CalculateYearlyInterestRate 
				@sum = 1000, 
				@yearlyInterestRate = 0.005, 
				@numberOfMonths = 12; 
 
SELECT @newSum; 

-------------------------------------------------

--4. Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
--It should take the AccountId and the interest rate as parameters.

USE Accounts
GO

CREATE PROC usp_GetPersonMonthlyInterestRate(@accountId int, @interestRate money)
AS
	DECLARE @newBalance money = (SELECT a.Balance FROM Accounts a WHERE @accountId = a.PersonId);


	UPDATE Accounts
	 SET Balance= dbo.ufn_CalculateYearlyInterestRate (@newBalance, @interestRate, 1)
	 WHERE Id = @AccountID
GO


BEGIN
	DECLARE @id int = 1
	SELECT p.[FirstName] + ' ' + p.[LastName], a.Balance AS [Before]
	FROM Persons p 
	JOIN Accounts a ON p.ID = a.PersonID
	WHERE a.Id = @id

	EXEC usp_GetPersonMonthlyInterestRate @id, 1.3

	SELECT p.[FirstName] + ' ' + p.[LastName], a.Balance AS [After]
	FROM Persons p 
	JOIN Accounts a ON p.ID = a.PersonID
	WHERE a.Id = @id
END

---------------------------------------------

-- 5. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that operate in transactions.

USE Accounts
GO

CREATE PROC usp_WithdrawMoney(@accountId int, @amount money)
AS
	DECLARE @balance money = (SELECT a.Balance FROM Accounts a
							WHERE a.Id = @accountId)
	BEGIN TRANSACTION

	IF @balance <= @amount
	BEGIN
		ROLLBACK
		RAISERROR('There are not enough money to proceed.', 16, 1);
		RETURN
	END

	UPDATE Accounts
		SET Balance = Balance - @amount
		WHERE Id = @accountId
	IF @@ROWCOUNT <> 1
	BEGIN
		ROLLBACK
		RAISERROR('Invalid ID', 16, 1);
		RETURN
	END
	COMMIT
GO


CREATE PROC usp_DepositMoney(@accountId int, @money money)
AS
	DECLARE @balance money = (SELECT a.Balance FROM Accounts a
							WHERE a.Id = @accountId)
	BEGIN TRANSACTION

	UPDATE Accounts
		SET Balance = Balance + @money
		WHERE Id = @accountId
	IF @@ROWCOUNT <> 1
	BEGIN
		ROLLBACK
		RAISERROR('Invalid ID', 16, 1);
		RETURN
	END
	COMMIT
GO

---------------------------------------------

--6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
--Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.

USE Accounts
GO

CREATE TABLE Logs
(
	LogID INT PRIMARY KEY IDENTITY,
	AccountID INT,
	OldSum money,
	NewSum money
)

GO

USE Accounts
GO

CREATE TABLE LastChangedBalances (OldBalance money, newBalance money)
GO

CREATE TRIGGER tr_Logs ON Accounts FOR UPDATE
AS
	(SELECT d.Balance AS [Old Sum], i.Balance AS [New Sum], d.ID AS [AccauntID]
	 INTO LastChangedBalances
	 FROM [deleted] d, [inserted] i)

	INSERT INTO dbo.Logs (AccountID, OldSum, NewSum) 
		SELECT ub.[AccountID], ub.[Old Sum], ub.[New Sum] 
		FROM LastChangedBalances ub
GO

--Test
EXEC usp_DepositMoney 2, 21
EXEC usp_DepositMoney 5, 222 
GO

---------------------------------------------

--7. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
--Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

USE TelerikAcademy
GO

CREATE FUNCTION ufn_GetEmployeesInTown(@letters nvarchar(50))
		RETURNS @tbl_EmployeesFromTowns TABLE
		([Name] nvarchar(50) NOT NULL,
		[Town] nvarchar(50) NOT NULL )
AS 
BEGIN
	INSERT @tbl_EmployeesFromTowns 
	SELECT e.[FirstName], t.[Name]
	
	FROM [Towns] t
	JOIN [Addresses] a ON a.[TownID] = t.[TownID]
	JOIN [Employees] e ON e.[AddressID] = a.[AddressID]
	WHERE t.Name IN
					(SELECT [Name] 
					FROM Towns 
					WHERE dbo.ufn_GetTownContainedInLetters(@letters, [Name]) = 1)

	RETURN
END
GO 

CREATE FUNCTION ufn_GetTownContainedInLetters(@letters nvarchar(50), @town nvarchar(50))
		RETURNS bit
AS 
BEGIN
	SET @letters = LOWER(@letters)
	SET @town = LOWER(@town)
	DECLARE @i int = 1
	DECLARE @char nvarchar(1)
	DECLARE @lengthOfTown int = LEN(@town)
	WHILE @lengthOfTown >= @i
	BEGIN
		SET @char = SUBSTRING(@town, @i, 1)
		IF CHARINDEX(@char, @letters, 1) = 0
		BEGIN
			RETURN 0
		END
		SET @i = @i + 1;
	END 
	RETURN 1
END
GO

--Test
SELECT * FROM dbo.ufn_GetEmployeesInTown('sofiaredmond')
GO

DROP FUNCTION dbo.ufn_GetEmployeesInTown
DROP FUNCTION ufn_GetTownContainedInLetters
GO
---------------------------------------------

--8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.

DECLARE db_Cursor CURSOR READ_ONLY FOR
  SELECT e.[FirstName], e.[LastName], t.[Name] 
  FROM Employees e
  JOIN Addresses a
  ON e.[AddressID] = a.[AddressID]
  JOIN Towns t
  ON a.[TownID] = t.[TownID]

OPEN db_Cursor
DECLARE @firstName nvarchar(50), @lastName nvarchar(50), @town nvarchar(50)
FETCH NEXT FROM db_Cursor INTO @firstName, @lastName, @town

WHILE @@FETCH_STATUS = 0
  BEGIN
  			  DECLARE db_Cursor1 CURSOR READ_ONLY FOR
			  SELECT e.[FirstName], e.[LastName], t.[Name] FROM Employees e
			  JOIN Addresses a
			  ON e.AddressID = a.AddressID
			  JOIN Towns t
			  ON a.[TownID] = t.[TownID]

			OPEN db_Cursor1
			DECLARE @firstName1 nvarchar(50), @lastName1 nvarchar(50), @town1 nvarchar(50)
			FETCH NEXT FROM db_Cursor1 INTO @firstName1, @lastName1, @town1

			WHILE @@FETCH_STATUS = 0
			  BEGIN
			  IF(@town = @town1 AND @firstName != @firstName1 AND @lastName != @lastName1)
				  BEGIN
					PRINT @town+':'+ @firstName + ' ' + @lastName + ':' + @firstName1 + ' ' + @lastName1 
				  END
				FETCH NEXT FROM db_Cursor1 INTO @firstName1, @lastName1, @town1
			  END

			CLOSE db_Cursor1
			DEALLOCATE db_Cursor1

    FETCH NEXT FROM db_Cursor  INTO @firstName, @lastName, @town
  END

CLOSE db_Cursor
DEALLOCATE db_Cursor


---------------------------------------------

--10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.
--For example the following SQL statement should return a single string:
--SELECT StrConcat(FirstName + ' ' + LastName)
--FROM Employees
----------------

USE TelerikAcademy;  
GO  
DECLARE @Path nvarchar(1024)  
  
SELECT @Path = REPLACE(physical_name, 'Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\master.mdf', 'Microsoft SQL Server\130\Samples\Engine\Programmability\CLR\')   
     FROM master.sys.database_files   
     WHERE name = 'master';  
  
CREATE ASSEMBLY StringUtilities FROM @Path + 'StringUtilities\CS\StringUtilities\bin\debug\StringUtilities.dll'  
WITH PERMISSION_SET=SAFE;  
GO  
  
CREATE AGGREGATE Concatenate(@input nvarchar(4000), @separator nvarchar(10))  
RETURNS nvarchar(max)  
EXTERNAL NAME [StringUtilities].[Microsoft.Samples.SqlServer.Concatenate];  
GO  

SELECT dbo.Concatenate(FirstName + ' ' + LastName, ', ')
FROM Employees
GO
DROP AGGREGATE Concatenate; 
DROP ASSEMBLY StringUtilities; 
GO
---------------------------------------------