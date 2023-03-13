# MoneyMe-LoanApi
Loan Application

1. Open LoanApplication.csproj
2. Update the database connection
	1. Open the solution 
	2. Goto appsettings.json
	3. Add value of Data Source to your MSSQL server instance.
3. Open Package Manager Console
	1. Type update-database
	2. Wait for it to finsih building and finish creating the database.
4. To test the API run LoanApplication 
5. Open Postman and enter the url and body and set it to POST request
	url - https://localhost:7055/api/LoanApplication/request-application
	body - 
		{
  			"amountRequired": 6000,
  			"term": 6,
  			"title": "Mr",
  			"firstName": "test",
  			"lastName": "test",
  			"dateOfBirth": "2023-03-02T09:29:25.029Z",
  			"mobile": "09219931458",
  			"email": "email@email.com"
		}
	* this will create a customer record and will use RedirectToAction 
