CREATE TABLE [Customer]
(
    [Id] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	[FirstName] VARCHAR(40) NOT NULL,
	[LastName] VARCHAR(40) NOT NULL,
	[BirthDate] DATETIME NOT NULL,
	[Document] CHAR(11) NOT NULL,
	[Email] VARCHAR(160) NOT NULL,
	[Phone] VARCHAR(13) NOT NULL

)

CREATE TABLE [Address]
(
	[Id] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	[CustomerId] UNIQUEIDENTIFIER NOT NULL,
	[Number] VARCHAR(10) NOT NULL,
	[Complement] VARCHAR(40) NOT NULL,
	[District] VARCHAR(60) NOT NULL,
	[City] VARCHAR(60) NOT NULL,
	[State] CHAR(2) NOT NULL,
	[Country] CHAR(2) NOT NULL,
	[ZipCode] CHAR(8) NOT NULL,
	FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([Id])
)