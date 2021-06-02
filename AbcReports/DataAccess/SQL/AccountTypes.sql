USE ABCReports;

CREATE TABLE dbo.AccountTypes(
	AccountTypeId		INT NOT NULL,
	AccountTypeName		VARCHAR(100) NOT NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[AccountTypes] VALUES (1, 'Checking');
INSERT INTO [dbo].[AccountTypes] VALUES (2, 'Savings');
