USE ABCReports;

CREATE TABLE dbo.Users(
	UserId		INT NOT NULL,
	FirstName	VARCHAR(100) NOT NULL,
	LastName	VARCHAR(100) NOT NULL,
	UserName	VARCHAR(100) NOT NULL,
	[Password]	VARCHAR(100) NOT NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[Users] VALUES (1, 'Simon', 'Mazzucca', 'SMazzucca', 'abc1')
GO