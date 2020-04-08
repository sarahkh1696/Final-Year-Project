CREATE PROCEDURE sproc_tblAdmin_Add
	-- create parameters for the stored procedure  
	@AdminName varchar (10)
	
	
AS
	INSERT INTO tblAdmin (AdminName)
	values (@AdminName)

--return the primary key value of the new record 
RETURN @@Identity
GO

CREATE PROCEDURE sproc_tblAdmin_Delete
	--this stored procedure is situated in the data layer (App_Data Folder) 

	--this stored procedure is used to delete a single record in the table tblAdmin 
	--it accespts a single parameter @AdminID and returns no value 

	--declare the parameter
	@AdminID int
AS
	--delete the record in tblAdmin specified by the value of @AdminID
	delete from tblAdmin where AdminID = @AdminID;
GO

CREATE PROCEDURE sproc_tblAdmin_FilteredByAdminID
	--parameter to identity user to find 
	@AdminID int 
	
AS
    --select records from the table with matching AdminID (should be 0 or 1) 
	SELECT * from tblAdmin where AdminID = @AdminID; 
RETURN 0
GO

CREATE PROCEDURE sproc_tblAdmin_Update
	--create the parameters for the stored procedure 
	@AdminID int,
	@AdminName varchar(50)
AS
--update the record as specified by @AdminID value 
update tblAdmin 
set AdminName = @AdminName

where AdminID = @AdminID
GO

CREATE PROCEDURE sproc_tblConsultant_Add
	-- create parameters for the stored procedure 
	@ConsultantName varchar (25), 
	@ConsultantSpecialist varchar (50), 
	@ConsultantComment varchar (Max), 
	@DrugType varchar (20), 
	@DateAdded date
		
AS
	INSERT INTO tblConsultant(ConsultantName, ConsultantSpecialist, ConsultantComment, DrugType, DateAdded)
	values (@ConsultantName, @ConsultantSpecialist, @ConsultantComment, @DrugType, @DateAdded)

--return the primary key value of the new record 
RETURN @@Identity
GO

CREATE PROCEDURE sproc_tblConsultant_FilteredByConsultantID
	--parameter to identity user to find 
	@ConsultantID int 
	
AS
    --select records from the table with matching ConsultantID (should be 0 or 1) 
	SELECT * from tblConsultant where ConsultantID = @ConsultantID; 
RETURN 0
GO

CREATE PROCEDURE sproc_tblConsultant_SelectAll
	
	AS
--Select all the records from the table
	SELECT *
	FROM tblConsultant

RETURN 0
GO

CREATE PROCEDURE sproc_tblConsultant_Update
	--create the parameters for the stored procedure 
	@ConsultantID int,
	@ConsultantName varchar(50), 
	@ConsultantSpecialist varchar(50), 
	@ConsultantComment  varchar(MAX),
	@DrugType varchar(20),
	@DateAdded DATE
	--@PatientID int

AS
--update the record as specified by @ConsultantID value 
update tblConsultant 
set @ConsultantName = @ConsultantName, 
    @ConsultantSpecialist = @ConsultantSpecialist, 
	@ConsultantComment = @ConsultantComment, 
	@DrugType = @DrugType,
	@DateAdded = @DateAdded

where ConsultantID = @ConsultantID
GO

CREATE PROCEDURE sproc_tblDrug_Add
	-- create parameters for the stored procedure
	@DrugName varchar (25),
	@DrugType varchar (20),
	@IssuedDate date,
	@ExpiryDate date,
	@Quantity int,
	@DrugPrice money
AS
	INSERT INTO tblDrug (DrugName, DrugType, IssuedDate, ExpiryDate, Quantity, DrugPrice)
	values (@DrugName, @DrugType, @IssuedDate, @ExpiryDate, @Quantity,@DrugPrice)

--return the primary key value of the new record 
RETURN @@Identity
GO

CREATE PROCEDURE sproc_tblDrug_Delete
	--this stored procedure is situated in the data layer (App_Data Folder) 

	--this stored procedure is used to delete a single record in the table tblDrug
	--it accespts a single parameter @DrugID and returns no value 

	--declare the parameter
	@DrugID int
AS
	--delete the record in tblDrug specified by the value of @DrugID
	delete from tblDrug where DrugID = @DrugID;
GO

CREATE PROCEDURE sproc_tblDrug_FilteredByDrugID
	--parameter to identity user to find 
	@DrugID int 
	
AS
    --select records from the table with matching DrugID (should be 0 or 1) 
	SELECT * from tblDrug where DrugID = @DrugID; 
RETURN 0
GO

CREATE PROCEDURE sproc_tblDrug_SelectAll
	
	AS
--Select all the records from the table
	SELECT *
	FROM tblDrug

RETURN 0
GO

CREATE PROCEDURE sproc_tblDrug_Update
	--create the parameters for the stored procedure 
	@DrugID int,
	@DrugName varchar(25), 
	@DrugType varchar(20), 
	@DrugPrice money,
	@IssuedDate date,
	@ExpiryDate date,
	@Quantity int
AS
--update the record as specified by @DrugID value 
update tblDrug
set @DrugName = @DrugName, 
    @DrugType = @DrugType, 
	@DrugPrice = @DrugPrice,
	@IssuedDate = @IssuedDate, 
	@ExpiryDate = @ExpiryDate,
	@Quantity = @Quantity

where DrugID = @DrugID
Go

CREATE PROCEDURE sproc_tblOrder_Add
--create parameters for the stored procedure 

	@DatePlaced date,  
	@ShippingAddress VARCHAR(50) = LE113SH, 
    @Quantity int = 7, 
	@TotalPrice money = 20

AS
--Insert the new record 
 INSERT INTO tblOrder (DatePlaced, ShippingAddress, Quantity, TotalPrice)
 values (@DatePlaced, @ShippingAddress, @Quantity, @TotalPrice)
 --return the primary key value of the new record
 return @@Identity
 GO

 CREATE PROCEDURE sproc_tblOrder_Delete
	--this stored procedure is situated in the data layer (App_Data folder)

	--this stored procedure is used to delete a single record in the table tblOrder
	--it accepts a single parameter @OrderID and returns no value 

	--declare the parameter 
	@OrderID int
AS
    --delete the record in tblOrder specified by the value of @OrderID
	delete from tblOrder where OrderID = @OrderID;
GO

CREATE PROCEDURE sproc_tblOrder_FilteredByOrderID
--parameter to store the order no we are looking for 
     @OrderID int 
AS
--Select all fields from the table where the order no matches the parameter data 
	SELECT * from tblOrder where [OrderID] = @OrderID
RETURN 0
GO

CREATE PROCEDURE sproc_tblOrder_SelectAll
	
AS
--Select all the records from the table
	SELECT *
	FROM tblOrder

RETURN 0
GO

CREATE PROCEDURE sproc_tblOrder_Update
--create the parameter for the stored procedure 
	@OrderID int,
	@OrderLineID int,
	@DatePlaced date, 
	@ShippingAddress VARCHAR(50),
	@Quantity int, 
	@TotalPrice money 

	AS 
	--update the record as specified by @OrderID value 
	update tblOrder 
	set 
	    DatePlaced = @DatePlaced,  
	    ShippingAddress = @ShippingAddress,
	    Quantity = @Quantity, 
	    TotalPrice = @TotalPrice  
	
	where OrderID=@OrderID
GO

CREATE PROCEDURE sproc_tblPatient_Add
	-- create parameters for the stored procedure 
	@FirstName varchar(10), 
	@LastName varchar(15), 
	@Gender varchar(9), 
	@Age int, 
	@AddressLine varchar(100), 
	@DateAdded date, 
	@ContactNo varchar (50) 
	
AS
	INSERT INTO tblPatient (FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo)
	values (@FirstName, @LastName, @Gender, @Age, @AddressLine, @DateAdded, @ContactNo)

--return the primary key value of the new record 
RETURN @@Identity
GO

CREATE PROCEDURE sproc_tblPatient_Delete
	--this stored procedure is situated in the data layer (App_Data Folder) 

	--this stored procedure is used to delete a single record in the table tblPatient 
	--it accespts a single parameter @PatientID and returns no value 

	--declare the parameter
	@PatientID int
AS
	--delete the record in tblPatient specified by the value of @PatientID
	delete from tblPatient where PatientID = @PatientID;
GO

CREATE PROCEDURE sproc_tblPatient_FilteredByPatientID
	--parameter to identity user to find 
	@PatientID int
	
AS
    --select records from the table with matching PatientID (should be 0 or 1) 
	SELECT * from tblPatient where PatientID = @PatientID; 
RETURN 0
GO

CREATE PROCEDURE sproc_tblPatient_SelectAll
	
	AS
--Select all the records from the table
	SELECT *
	FROM tblPatient

RETURN 0
GO

CREATE PROCEDURE sproc_tblPatient_Update
	--create the parameters for the stored procedure 
	@PatientID int,
	@FirstName varchar(10),
	@LastName varchar(15),
	@Gender varchar(9),
	@Age int,
	@AddressLine varchar(100),
	@DateAdded Date,
	@ContactNo varchar(50)

AS
--update the record as specified by @PatientID value 
update tblPatient
set @FirstName = @FirstName,
    @LastName = @LastName,
	@Gender = @Gender,
	@Age = @Age, 
	@AddressLine = @AddressLine, 
	@DateAdded = @DateAdded, 
	@ContactNo = @ContactNo

where PatientID = @PatientID
GO

CREATE PROCEDURE sproc_tblPharmacist_Add
	-- create parameters for the stored procedure 
	@PharmacistName varchar (50), 
	@ContactNo varchar (50) 
	
	
AS
	INSERT INTO tblPharmacist(PharmacistName, ContactNo)
	values (@PharmacistName, @ContactNo)
--return the primary key value of the new record 
RETURN @@Identity
GO

CREATE PROCEDURE sproc_tblPharmacist_Delete
	--this stored procedure is situated in the data layer (App_Data Folder) 

	--this stored procedure is used to delete a single record in the table tblPharmacist 
	--it accespts a single parameter @PharmacistID and returns no value 

	--declare the parameter
	@PharmacistID int
AS
	--delete the record in tblPharmacist specified by the value of @PharmacistID
	delete from tblPharmacist where PharmacistID= @PharmacistID;
GO

CREATE PROCEDURE sproc_tblPharmacist_FilteredByPharmacistID
	--parameter to identity user to find 
	@PharmacistID int 
	
AS
    --select records from the table with matching PharmacistID (should be 0 or 1) 
	SELECT * from tblPharmacist where PharmacistID = @PharmacistID; 
RETURN 0
GO

CREATE PROCEDURE sproc_tblPharmacist_Update
	--create the parameters for the stored procedure 
	@PharmacistID int,
	@PharmacistName varchar(50),
	@ContactNo varchar(50)
AS
--update the record as specified by @PharmacistID value 
update tblPharmacist
set @PharmacistName = @PharmacistName,
    @ContactNo = @ContactNo

where PharmacistID = @PharmacistID
GO

CREATE PROCEDURE sproc_tblPharmacy_FilteredByPharmacyID
--parameter to store the order no we are looking for 
     @PharmacyID int 
AS
--Select all fields from the table where the order no matches the parameter data 
	SELECT * from tblPharmacy where [PharmacyID] = @PharmacyID
RETURN 0
GO