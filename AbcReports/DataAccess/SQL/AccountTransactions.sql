USE ABCReports;

DROP TABLE dbo.AccountTransactions;
GO

CREATE TABLE dbo.AccountTransactions(
	TransactionId		INT NOT NULL,
	TransactionDate	DATE NOT NULL,
	AccountId			VARCHAR(100) NOT NULL,
	TransactionType		VARCHAR(1) NOT NULL,
	Amount				MONEY NOT NULL,
	Description			VARCHAR(100) NOT NULL
) ON [PRIMARY]
GO

--Checking Transactions
INSERT INTO [dbo].AccountTransactions VALUES(1, '5/24/2021', 1, 'P', -64.61, 'Debit Card Purchase 05/20 08:45p #3481 MEZZALUNA BREWSTER NY 21141');
INSERT INTO [dbo].AccountTransactions VALUES(2, '5/21/2021', 1, 'C', -625, 'Check # 163');
INSERT INTO [dbo].AccountTransactions VALUES(3, '5/21/2021', 1, 'D', -500, 'Transfer to Money Market 06:05a #3481 ONLINE Reference # 010023');
INSERT INTO [dbo].AccountTransactions VALUES(4, '5/18/2021', 1, 'C', 2300, 'Mobile Deposit ');
INSERT INTO [dbo].AccountTransactions VALUES(5, '5/18/2021', 1, 'C', 500, 'Mobile Deposit ');
INSERT INTO [dbo].AccountTransactions VALUES(6, '5/14/2021', 1, 'C', 1000, 'Paycheck');
INSERT INTO [dbo].AccountTransactions VALUES(7, '5/14/2021', 1, 'C', 500, 'Mobile Deposit ');
INSERT INTO [dbo].AccountTransactions VALUES(8, '5/13/2021', 1, 'D', -126.62, 'CON ED OF NY INTELL CK ');
INSERT INTO [dbo].AccountTransactions VALUES(9, '5/13/2021', 1, 'D', -104.2, 'CON ED OF NY INTELL CK ');
INSERT INTO [dbo].AccountTransactions VALUES(10, '5/13/2021', 1, 'D', -51.41, 'CON ED OF NY INTELL CK ');
INSERT INTO [dbo].AccountTransactions VALUES(11, '5/13/2021', 1, 'C', 1000, 'MTS PROMOTIONS, QUICKBOOKS');
INSERT INTO [dbo].AccountTransactions VALUES(12, '5/12/2021', 1, 'C', -12000, 'Check # 162');
INSERT INTO [dbo].AccountTransactions VALUES(13, '5/11/2021', 1, 'C', 30000, 'FID BKG SVC LLC MONEYLINE');
INSERT INTO [dbo].AccountTransactions VALUES(14, '5/6/2021', 1, 'D', -438.27, 'CHASE CREDIT CRD AUTOPAY ');
INSERT INTO [dbo].AccountTransactions VALUES(15, '5/6/2021', 1, 'D', -780.1, 'Maintenance');
INSERT INTO [dbo].AccountTransactions VALUES(16, '5/4/2021', 1, 'D', -443.1, 'AMERICAN GENERAL SMARTDEC01 161');
INSERT INTO [dbo].AccountTransactions VALUES(17, '5/4/2021', 1, 'D', -7313.42, 'AMERICAN EXPR ACH PMT A2378 1');
INSERT INTO [dbo].AccountTransactions VALUES(18, '5/3/2021', 1, 'D', -2751.75, '120-88 Owners Co WEB PMTS SFRSZ1');
INSERT INTO [dbo].AccountTransactions VALUES(19, '5/3/2021', 1, 'D', -1886.28, '120-88 Owners Co WEB PMTS NGRSZ1');
INSERT INTO [dbo].AccountTransactions VALUES(20, '4/30/2021', 1, 'C', 3917.45, 'INTERCONTINENTAL DIR DEP');
INSERT INTO [dbo].AccountTransactions VALUES(21, '4/30/2021', 1, 'C', 0.44, 'Interest Payment');


--Savings Transactions
INSERT INTO [dbo].AccountTransactions VALUES(22, '1/1/2021', 2, 'D', 1000, 'Transfer from Checking');
INSERT INTO [dbo].AccountTransactions VALUES(23, '2/1/2021', 2, 'D', 1000, 'Transfer from Checking');
INSERT INTO [dbo].AccountTransactions VALUES(24, '3/1/2021', 2, 'D', 1000, 'Transfer from Checking');
INSERT INTO [dbo].AccountTransactions VALUES(25, '4/1/2021', 2, 'D', 1000, 'Transfer from Checking');
INSERT INTO [dbo].AccountTransactions VALUES(26, '5/1/2021', 2, 'D', 1000, 'Transfer from Checking');


