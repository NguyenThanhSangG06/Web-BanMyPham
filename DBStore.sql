CREATE DATABASE QLCuaHang
GO

USE QLCuaHang
GO

CREATE TABLE Roles
(
	RoleID INT IDENTITY PRIMARY KEY NOT NULL,
    RoleName NVARCHAR(50) NOT NULL,
	Description NVARCHAR(50)
)
GO

CREATE TABLE Accounts
(
	AccountID INT IDENTITY PRIMARY KEY NOT NULL,
	Phone VARCHAR(12),
	Email  NVARCHAR(100),
	Password NVARCHAR(50),
	Salt NCHAR(6),
	Active BIT NOT NULL,
	FullName NVARCHAR(150),
	RoleID INT,
	LastLogin DATETIME,
	CreateDate DATETIME

	FOREIGN KEY (RoleID) REFERENCES dbo.Roles(RoleID)
)
GO

CREATE TABLE Categories
(
	CatID INT IDENTITY PRIMARY KEY NOT NULL,
	CatName NVARCHAR(150),
	Description NVARCHAR(MAX),
	ParentID INT,
	Levels INT,
	Ordering INT,
	Published BIT NOT NULL,
	Thumb NVARCHAR(250),
	Title NVARCHAR(250),
	Alias NVARCHAR(250),	 
	MetaDesc NVARCHAR(250),
	MetaKey NVARCHAR(250),
	Cover NVARCHAR(250),
	SchemaMarkup NVARCHAR(MAX)
)
GO

CREATE TABLE Locations
(
	LocationID INT IDENTITY PRIMARY KEY NOT NULL,
	Name NVARCHAR(100),
	Type NVARCHAR(20),
	Slug NVARCHAR(100),
	NameWithType NVARCHAR(250),
	PathWithType NVARCHAR(250),
	ParrentCode INT,
	Levels INT
)
GO

CREATE TABLE Customers
(
	CustomerID INT IDENTITY PRIMARY KEY NOT NULL,
	FullName NVARCHAR(150),
	Birthday DATETIME,
	Avatar NVARCHAR(250),
	Address NVARCHAR(250),
	Email  NVARCHAR(100),
	Phone VARCHAR(12),
	LocationID INT,
	District INT,
	Ward INT,
	CreateDate DATETIME,
	Password NVARCHAR(50),
	Salt NCHAR(6),
	LastLogin DATETIME,
	Active BIT NOT NULL

	FOREIGN KEY (LocationID) REFERENCES dbo.Locations(LocationID)
)
GO

CREATE TABLE TransactStatus
(
	TransactStatusID INT IDENTITY PRIMARY KEY NOT NULL,
    Status NVARCHAR(50),
	Description NVARCHAR(MAX)
)
GO

CREATE TABLE Orders
(
	OrderID INT IDENTITY PRIMARY KEY NOT NULL,
	CustomerID INT,
	OrderDate DATETIME,
	ShipDate DATETIME,
	TransactStatusID INT,
	Delected BIT,
	Paid BIT,
	PaymentDay DATETIME,
	PaymentID INT,
	Note NVARCHAR(MAX)

	FOREIGN KEY (TransactStatusID) REFERENCES dbo.TransactStatus(TransactStatusID),
	FOREIGN KEY (CustomerID) REFERENCES dbo.Customers(CustomerID)
)
GO

CREATE TABLE OrderDetails
(
	OrderDetailID INT IDENTITY PRIMARY KEY NOT NULL,
	OrderID INT,
	ProductID INT,
	OrderNumber INT,
	Quantity INT,
	Discount INT,
	Total INT,
	ShipDate DATETIME

	FOREIGN KEY (OrderID) REFERENCES dbo.Orders(OrderID)
)
GO

CREATE TABLE Pages
(
	PageID INT IDENTITY PRIMARY KEY NOT NULL,
    PageName NVARCHAR(250),
	Contents NVARCHAR(MAX),
	Thumb NVARCHAR(250),
	Published BIT NOT NULL,
	Title NVARCHAR(250),	 
	MetaDesc NVARCHAR(250),
	MetaKey NVARCHAR(250),
	Alias NVARCHAR(250),
	CreatedAt DATETIME,
	Ordering INT
)
GO

CREATE TABLE Products
(
	ProductID INT IDENTITY PRIMARY KEY NOT NULL,
    ProductName NVARCHAR(250) NOT NULL,
	ShortDesc NVARCHAR(250),
	Description NVARCHAR(MAX),
	CatID INT,
	Price INT,
	Discount INT,
	Thumb NVARCHAR(250),
	Video NVARCHAR(250),
	DateCreate DATETIME,
	DateModified DATETIME,
	BestSeller BIT NOT NULL,
	HomeFlag BIT NOT NULL,
    Active BIT NOT NULL,
	Tags NVARCHAR(MAX),
	Title NVARCHAR(250),
	Alias NVARCHAR(250),	 
	MetaDesc NVARCHAR(250),
	MetaKey NVARCHAR(250),
	UnitslnStock INT

	FOREIGN KEY (CatID) REFERENCES dbo.Categories(CatID)
)
GO

CREATE TABLE Shippers
(
	ShipperID INT IDENTITY PRIMARY KEY NOT NULL,
    ShipperName NVARCHAR(150),
	Phone VARCHAR(12),
	ShipDate DATETIME
)
GO

CREATE TABLE TinTucs
(
	PostID INT IDENTITY PRIMARY KEY NOT NULL,
    Title NVARCHAR(250),
	SContents NVARCHAR(MAX),
	Thumb NVARCHAR(250),
	Published BIT NOT NULL,
	Alias NVARCHAR(250),
	CreatedDate DATETIME,
	Author NVARCHAR(250),
	AccountID INT,
	Tags NVARCHAR(MAX),
	CatID INT,
	IsHot BIT NOT NULL,
	IsNewfeed BIT NOT NULL,
	MetaDesc NVARCHAR(250),
	MetaKey NVARCHAR(250),
	Views INT
)
GO

CREATE TABLE Attributes
(
	AttributeID INT IDENTITY PRIMARY KEY NOT NULL,
	Name NVARCHAR(100)
)
GO

CREATE TABLE AttributesPrices
(
	AttributesPricesID INT IDENTITY PRIMARY KEY NOT NULL,
	AttributeID INT,
	ProductID INT,
	Price INT,
	Active BIT NOT NULL

	FOREIGN KEY (ProductID) REFERENCES dbo.Products(ProductID),
	FOREIGN KEY (AttributeID) REFERENCES dbo.Attributes(AttributeID)
)
GO



