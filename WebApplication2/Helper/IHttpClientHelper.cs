using WebApplication2.Models;

namespace WebApplication2.Helper
{
    public interface IHttpClientHelper
    {
        /// <summary>
        /// Get customers data from business central.
        /// </summary>
        /// <returns></returns>
        Task<CustomerModel> GetAllCustomerDataFromBusinessCentral();

        /// <summary>
        /// Add customer to business central.
        /// </summary>
        /// <param name="customerInput"></param>
        /// <returns></returns>
        Task<CustomerOutputModel> AddCustomerToBusinessCentral(CustomerInput customerInput);

        Task<CustomerOutputModel> UpdateCustomerToBusinessCentral(CustomerInput customerInput, string customerId);

        /// <summary>
        /// Delete customer from business central
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<bool> DeleteCustomerFromBusinessCentral(string customerId);

        /// <summary>
        /// Get customers by query options
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        Task<CustomerModel> GetCustomersByQueryOption(QueryOptions queryOptions);
    }
}