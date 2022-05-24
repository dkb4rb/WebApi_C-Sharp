CREATE DATABASE WebApi;

USE  WebApi;

CREATE TABLE Ownerr (
	IdOwner INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name varchar(30)NOT NULL,
	Address varchar(50)NOT NULL,
	Photo varchar(100)NOT NULL,
	Birthday date NOT NULL
);

select * from Ownerr;



CREATE TABLE Property (
	IdProperty INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name varchar(50),
	Address varchar(50),
	Price money,
	CodeInterval bit,
	Yearr DATETIME,
	IdOwner INT FOREIGN KEY REFERENCES Ownerr(IdOwner)
	);

CREATE TABLE PropertyImage (
	IdPropertyImage INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	FilesUrl varchar(MAX),
	IdProperty INT FOREIGN KEY REFERENCES Property(IdProperty)
);


CREATE TABLE PropertyTrace(
	IdPropertySale INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	DateSale DATETIME,
	Name varchar(30),
	Value varchar(30),
	Tax varchar(30),
	IdProperty INT FOREIGN KEY REFERENCES Property(IdProperty),
);
