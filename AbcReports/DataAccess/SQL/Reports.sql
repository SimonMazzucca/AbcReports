USE ABCReports;

CREATE TABLE dbo.Reports(
	ReportId		INT NOT NULL,
	ReportName		VARCHAR(100) NOT NULL,
	CreationDate	Date NOT NULL,
	AccountId		INT NOT NULL,
	[Period]		CHAR(3) NOT NULL	--PWK, PMT, MTD, YTD
) ON [PRIMARY]
GO


INSERT INTO [dbo].[Reports] VALUES (1, 'Mazzucca Checking (Previous Week)', GETDATE(), 1, 'PWK');
INSERT INTO [dbo].[Reports] VALUES (2, 'Mazzucca Checking (MTD)', GETDATE(), 1, 'MTD');
INSERT INTO [dbo].[Reports] VALUES (3, 'Mazzucca Savings (YTD)', GETDATE(), 1, 'YTD');
