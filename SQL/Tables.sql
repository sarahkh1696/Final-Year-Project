CREATE TABLE [dbo].[tblPharmacy] (
    [PharmacyID]   INT          NOT NULL IDENTITY(1,1),
    [PharmacyName] VARCHAR (20) NOT NULL,
    [Address]      VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([PharmacyID] ASC)
);

CREATE TABLE [dbo].[tblPharmacist] (
    [PharmacistID]   INT          NOT NULL IDENTITY(1,1),
    [PharmacistName] VARCHAR (50) NOT NULL,
    [ContactNo]      VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([PharmacistID] ASC)
);

CREATE TABLE [dbo].[tblPayment] (
    [PaymentID]   INT          NOT NULL IDENTITY(1,1),
    [PatientID]   INT          NOT NULL,
    [PaymentType] VARCHAR (25) NOT NULL,
    [PaymentDate] DATE         NOT NULL,
    [Price]       MONEY        NOT NULL,
    PRIMARY KEY CLUSTERED ([PaymentID] ASC)
);

CREATE TABLE [dbo].[tblPatient] (
    [PatientID]   INT           NOT NULL IDENTITY (1, 1),
    [FirstName]   VARCHAR (10)  NOT NULL,
    [LastName]    VARCHAR (15)  NOT NULL,
    [Gender]      VARCHAR (9)   NOT NULL,
    [Age]         INT           NOT NULL,
    [AddressLine] VARCHAR (100) NOT NULL,
    [DateAdded]   DATE          NOT NULL,
    [ContactNo]   VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([PatientID] ASC)
);

CREATE TABLE [dbo].[tblOrderLine] (
    [OrderLineID] INT NOT NULL IDENTITY (1, 1),
    [OrderID]     INT NOT NULL,
    [DrugID]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderLineID] ASC)
);

CREATE TABLE [dbo].[tblOrder] (
    [OrderID]         INT          NOT NULL IDENTITY (1, 1),
    [PatientID ]      INT          NOT NULL,
    [DatePlaced]      DATE         NOT NULL,
    [Quantity]        INT          NOT NULL,
    [ShippingAddress] VARCHAR (50) NOT NULL,
    [TotalPrice]      MONEY        NOT NULL,
    [OrderLineID]     INT          NULL,
    PRIMARY KEY CLUSTERED ([OrderID] ASC)
);

CREATE TABLE [dbo].[tblEmail] (
    [EmailID]        INT           NOT NULL IDENTITY (1, 1),
    [SenderEmail]    VARCHAR (50)  NOT NULL,
    [RecipientEmail] VARCHAR (50)  NOT NULL,
    [SubjectLine ]   VARCHAR (15)  NOT NULL,
    [Message]        VARCHAR (100) NOT NULL
);

CREATE TABLE [dbo].[tblDrug] (
    [DrugID]     INT          NOT NULL IDENTITY (1, 1),
    [DrugName]   VARCHAR (25) NOT NULL,
    [DrugType]   VARCHAR (20) NOT NULL,
    [IssuedDate] DATE         NOT NULL,
    [ExpiryDate] DATE         NOT NULL,
    [Quantity]   INT          NOT NULL,
    [DrugPrice]  MONEY        NOT NULL,
    PRIMARY KEY CLUSTERED ([DrugID] ASC)
);

CREATE TABLE [dbo].[tblConsultant] (
    [ConsultantID]         INT           NOT NULL IDENTITY (1, 1),
    [ConsultantName]       VARCHAR (25)  NOT NULL,
    [ConsultantSpecialist] VARCHAR (50)  NOT NULL,
    [ConsultantComment]    VARCHAR (MAX) NOT NULL,
    [DrugType]             VARCHAR (20)  NOT NULL,
    [DateAdded]            DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([ConsultantID] ASC)
);

CREATE TABLE [dbo].[tblAdmin] (
    [AdminID]   INT          NOT NULL IDENTITY (1, 1),
    [AdminName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([AdminID] ASC)
);

CREATE TABLE [dbo].[tblAccount] (
    [AccountID] INT          NOT NULL IDENTITY (1, 1),
    [Email]     VARCHAR (50) NOT NULL,
    [Password]  VARCHAR (50) NOT NULL,
    [IsAdmin]   BIT          NOT NULL,
    [Active]    BIT          NOT NULL,
    [TempPW]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([AccountID] ASC)
);

