USE ABCReports;

DROP TABLE dbo.Accounts;
GO

CREATE TABLE dbo.Accounts(
	AccountId		INT NOT NULL,
	AccountNumber	VARCHAR(100) NOT NULL,
	TypeId			INT NOT NULL,
	UserId			INT NOT NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].Accounts VALUES(1, '123-555-6687', 1, 1);
INSERT INTO [dbo].Accounts VALUES(2, '789-555-2245', 2, 1);
