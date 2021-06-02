USE ABCReports;

SELECT 
	a.AccountNumber,
	
	at.TransactionDate,
	at.TransactionType,
	at.Amount,
	at.Description

FROM AccountTransactions at
	LEFT JOIN Accounts a on at.AccountId=a.AccountId
	
WHERE 1=1
	--AND a.AccountNumber = '123-555-6687'
	AND a.AccountNumber = '789-555-2245'

ORDER BY TransactionDate