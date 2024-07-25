using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using WebApplication2.Models;
using WebApplication2.Service;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/v1/businessCentral")]
    public class BusinessCentralController : ControllerBase
    {
        private readonly IBusinessCentalService _businessCentalService;

        public BusinessCentralController(IBusinessCentalService businessCentalService)
        {
            _businessCentalService = businessCentalService;
        }

        /// <summary>
        /// Get all customers from Bisiness central
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("customers")]
        [EnableQuery]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {
                return Ok(await _businessCentalService.GetAllCustomers());
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get customers by query options
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("customers-query")]
        [EnableQuery]
        public async Task<IActionResult> GetCustomersByQueryoption([FromBody] QueryOptions queryOptions)
        {
            try
            {
                return Ok(await _businessCentalService.GetCustomersByQueryoption(queryOptions));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Add customer to business central data
        /// </summary>
        /// <param name="customerInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("customers")]
        [EnableQuery]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerInput customerInput)
        {
            try
            {
                return Ok(await _businessCentalService.AddCustomer(customerInput));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        [Route("customers")]
        [EnableQuery]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerInput customerInput, [FromQuery] string customerId)
        {
            try
            {
                return Ok(await _businessCentalService.UpdateCustomer(customerInput, customerId));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Delete the customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("customers")]
        [EnableQuery]
        public async Task<IActionResult> DeleteCustomer([FromQuery] string customerId)
        {
            try
            {
                return Ok(await _businessCentalService.DeleteCustomer(customerId));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}