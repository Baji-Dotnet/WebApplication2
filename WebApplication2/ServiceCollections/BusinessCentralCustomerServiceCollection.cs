using WebApplication2.Helper;
using WebApplication2.Service;

namespace WebApplication2.ServiceCollections
{
    public static class BusinessCentralCustomerServiceCollection
    {
        public static void AddbusinessCentralCustomerServices(this IServiceCollection services)
        {
            services.AddSingleton<IBusinessCentalService, BusinessCentalService>();
            services.AddSingleton<IHttpClientHelper, HttpClientHelper>();
        }
    }
}