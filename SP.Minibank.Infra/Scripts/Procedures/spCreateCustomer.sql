CREATE PROCEDURE spCreateCustomer
    @Id UNIQUEIDENTIFIER,
    @FirstName VARCHAR(40),
    @LastName VARCHAR(40),
    @BirthDate DATETIME,
    @Document CHAR(11),
    @Email VARCHAR(160),
    @Phone VARCHAR(13)
AS
    INSERT INTO [Customer] (
        [Id], 
        [FirstName], 
        [LastName], 
        [BirthDate],
        [Document], 
        [Email], 
        [Phone]
    ) VALUES (
        @Id,
        @FirstName,
        @LastName,
        @BirthDate,
        @Document,
        @Email,
        @Phone
    )