using WebApplication2.Helper;

namespace WebApplication2.ServiceCollections
{
    public static class ServiceCollectionClass
    {
        public static void AddProjectServices(this IServiceCollection services, WebApplicationBuilder? builder)
        {
            services.AddbusinessCentralCustomerServices();
            services.AddHttpClient<IHttpClientHelper, HttpClientHelper>();
            //Other entity service collections can be configured according to their folders.
        }
    }
}