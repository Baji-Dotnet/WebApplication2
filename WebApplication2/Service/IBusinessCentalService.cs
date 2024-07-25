using WebApplication2.Models;

namespace WebApplication2.Service
{
    public interface IBusinessCentalService
    {
        /// <summary>
        /// Get customers from Bisiness central.
        /// </summary>
        /// <returns></returns>
        Task<CustomerModel> GetAllCustomers();

        /// <summary>
        /// Add customer to business central.
        /// </summary>
        /// <param name="customerInput"></param>
        /// <returns></returns>
        Task<CustomerOutputModel> AddCustomer(CustomerInput customerInput);

        /// <summary>
        /// Update customer to business central.
        /// </summary>
        /// <param name="customerInput"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<CustomerOutputModel> UpdateCustomer(CustomerInput customerInput, string customerId);

        /// <summary>
        /// Delete customer from business central.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<bool> DeleteCustomer(string customerId);

        /// <summary>
        /// Get customers by query options
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        Task<CustomerModel?> GetCustomersByQueryoption(QueryOptions queryOptions);
    }
}