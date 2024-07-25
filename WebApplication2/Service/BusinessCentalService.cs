using WebApplication2.Helper;
using WebApplication2.Models;

namespace WebApplication2.Service
{
    public class BusinessCentalService : IBusinessCentalService
    {
        private readonly IHttpClientHelper _httpClientHelper;

        public BusinessCentalService(IHttpClientHelper httpClientHelper)
        {
            _httpClientHelper = httpClientHelper;
        }

        /// <summary>
        /// Get all customers from Bisiness central
        /// </summary>
        /// <returns></returns>
        public async Task<CustomerModel> GetAllCustomers()
        {
            return await _httpClientHelper.GetAllCustomerDataFromBusinessCentral();
        }

        /// <summary>
        /// Add customer to business central data
        /// </summary>
        /// <param name="customerInput"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<CustomerOutputModel> AddCustomer(CustomerInput customerInput)
        {
            return await _httpClientHelper.AddCustomerToBusinessCentral(customerInput);
        }

        public async Task<CustomerOutputModel> UpdateCustomer(CustomerInput customerInput, string customerId)
        {
            return await _httpClientHelper.UpdateCustomerToBusinessCentral(customerInput, customerId);
        }

        /// <summary>
        /// Delete customer from business central
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteCustomer(string customerId)
        {
            return await _httpClientHelper.DeleteCustomerFromBusinessCentral(customerId);
        }

        /// <summary>
        /// Get customers by query options
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<CustomerModel?> GetCustomersByQueryoption(QueryOptions queryOptions)
        {
            return await _httpClientHelper.GetCustomersByQueryOption(queryOptions);
        }
    }
}