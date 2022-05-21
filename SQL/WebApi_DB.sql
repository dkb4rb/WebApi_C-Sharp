CREATE DATABASE WebApi;

USE  WebApi;

CREATE TABLE Ownerr (
	IdOwner INT PRIMARY KEY,
	Name varchar(30),
	Address varchar(50),
	Photo varchar(100),
	Birthday date
);

select * from Ownerr;



CREATE TABLE Property (
	IdProperty INT PRIMARY KEY,
	Name varchar(50),
	Address varchar(50),
	Price DECIMAL(1),
	CodeInterval varchar(10),
	Yearr DATETIME,
	IdOwner INT FOREIGN KEY REFERENCES Ownerr(IdOwner));

CREATE TABLE PropertyImage (
	IdPropertyImage INT PRIMARY KEY,
	FilesUrl varchar(1000),
	IdProperty INT FOREIGN KEY REFERENCES Property(IdProperty)
);


CREATE TABLE PropeertyTrace(
	IdPropertySale INT  PRIMARY KEY,
	DateSale DATETIME,
	Name varchar(30),
	Value varchar(30),
	Tax varchar(30),
	IdProperty INT FOREIGN KEY REFERENCES Property(IdProperty),
);
