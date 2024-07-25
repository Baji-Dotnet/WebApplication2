# This is sample assignment project which is create by using following technologies
.Net core version 6.0
 C# version 10.0
 This project mostly connects to Business Central and performs CRUD activities. 
 I've created five endpoints as below.
1. GetAllCustomers: which gets all customers from business central
   Url: [GET] http://localhost:5291/api/v1/businessCentral/customers
2. GetCustomersByQueryoption: Gets customers based on query options
   Url: [POST] http://localhost:5291/api/v1/businessCentral/customers
   Sample payload:
   {
     "filterOption1": "top",
     "nomberOfRows": "2"
   }
3. AddCustomer: This endpoint add the customers to Business central.
   Url: [POST] http://localhost:5291/api/v1/businessCentral/customers
   Sample payload:
   {
     "Name": "Baji",
     "No": "112"
   }
4. UpdateCustomer: This endpoint updates the exisitng customer.
   Url: [PUT] http://localhost:5291/api/v1/businessCentral/customers?customerId=112
   Sample payload:
   {
     "Name": "BajiUpdate",
     "No": "112"
   }
5. DeleteCustomer: This endpoint deletes the existing customer.
   Url: [Delete] http://localhost:5291/api/v1/businessCentral/customers?customerId=112
   