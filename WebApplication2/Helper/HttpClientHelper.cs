using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Helper
{
    public class HttpClientHelper : IHttpClientHelper
    {
        private readonly IConfiguration _configuration;
        private HttpClient _httpClient;
        private string _businessCentralCustomerCardUrl;

        public HttpClientHelper(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
            _businessCentralCustomerCardUrl = _configuration["OAuthOptions:BusinessCentralCustomerCardUrl"];
        }

        #region Http Proxy Methods

        /// <summary>
        /// Get all customers from business central
        /// </summary>
        /// <returns></returns>
        public async Task<CustomerModel> GetAllCustomerDataFromBusinessCentral()
        {
            var BearerToken = await GetBearerToken();
            using var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_businessCentralCustomerCardUrl)
            };
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
            var response = await _httpClient.SendAsync(requestMessage);
            var result = await response.Content.ReadAsStringAsync();
            var apiresponse = response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<CustomerModel>(result);
        }

        /// <summary>
        /// Get customers by query options
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<CustomerModel> GetCustomersByQueryOption(QueryOptions queryOptions)
        {
            var BearerToken = await GetBearerToken();
            _businessCentralCustomerCardUrl = $"{_businessCentralCustomerCardUrl}{"?"}{"$"}{queryOptions.FilterOption1}{"="}{queryOptions.NomberOfRows}";
            using var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_businessCentralCustomerCardUrl)
            };
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
            var response = await _httpClient.SendAsync(requestMessage);
            var result = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<CustomerModel>(result);
        }

        /// <summary>
        /// Add customer to business central.
        /// </summary>
        /// <param name="customerInput"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<CustomerOutputModel> AddCustomerToBusinessCentral(CustomerInput customerInput)
        {
            var BearerToken = await GetBearerToken();
            using var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(customerInput), Encoding.UTF8, "application/json"),
                RequestUri = new Uri(_businessCentralCustomerCardUrl)
            };
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
            var response = await _httpClient.SendAsync(requestMessage);
            var result = await response.Content.ReadAsStringAsync();
            var apiresponse = response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<CustomerOutputModel>(result);
        }

        public async Task<CustomerOutputModel> UpdateCustomerToBusinessCentral(CustomerInput customerInput, string customerId)
        {
            var BearerToken = await GetBearerToken();
            _businessCentralCustomerCardUrl = _businessCentralCustomerCardUrl + "('" + customerId + "')";
            using var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                Content = new StringContent(JsonConvert.SerializeObject(customerInput), Encoding.UTF8, "application/json"),
                RequestUri = new Uri(_businessCentralCustomerCardUrl)
            };
            requestMessage.Headers.TryAddWithoutValidation("If-Match", "*");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
            var response = await _httpClient.SendAsync(requestMessage);
            var result = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<CustomerOutputModel>(result);
        }

        /// <summary>
        /// Delete customer from business central
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteCustomerFromBusinessCentral(string customerId)
        {
            var BearerToken = await GetBearerToken();
            _businessCentralCustomerCardUrl = _businessCentralCustomerCardUrl + "('" + customerId + "')";
            using var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(_businessCentralCustomerCardUrl)
            };
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
            var response = await _httpClient.SendAsync(requestMessage);
            var result = await response.Content.ReadAsStringAsync();
            var apiresponse = response.EnsureSuccessStatusCode();
            return apiresponse.IsSuccessStatusCode;
        }

        #endregion Http Proxy Methods

        #region Supporting Methods

        /// <summary>
        /// Get brearer token
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetBearerToken()
        {
            var oAuthModel = await GetOAuthConfigurationValues();
            string URL = oAuthModel.Msbaseurl + oAuthModel.TenantId + oAuthModel.MsEndUrl;
            StringContent content = GetHttpContent(oAuthModel);
            content.Headers.ContentType = new MediaTypeHeaderValue(oAuthModel.MediaTypeHeaderValue);
            var response = await _httpClient.PostAsync(URL, content);
            response.EnsureSuccessStatusCode();
            var Result = JObject.Parse(await response?.Content?.ReadAsStringAsync());
            return Result["access_token"]?.ToString();
        }

        /// <summary>
        /// Get OAuth configurations from appsettings file
        /// </summary>
        /// <returns></returns>
        private Task<OAuthModel> GetOAuthConfigurationValues()
        {
            var oAuthModel = new OAuthModel()
            {
                ClientId = _configuration["OAuthOptions:ClientId"],
                ClientSecret = _configuration["OAuthOptions:ClientSecret"],
                TenantId = _configuration["OAuthOptions:TenantId"],
                Msbaseurl = _configuration["OAuthOptions:MicrosoftOnlineBaseUrl"],
                MsEndUrl = _configuration["OAuthOptions:MicrosoftOnlineEndUrl"],
                Scope = _configuration["OAuthOptions:Scope"],
                MediaTypeHeaderValue = _configuration["OAuthOptions:MediaTypeHeaderValue"],
                grantType = _configuration["OAuthOptions:grant_type"],
            };
            return Task.FromResult(oAuthModel);
        }

        /// <summary>
        /// Get http content
        /// </summary>
        /// <param name="oAuthModel"></param>
        /// <returns></returns>
        private static StringContent GetHttpContent(OAuthModel oAuthModel)
        {
            return new StringContent("grant_type=" + oAuthModel.grantType + "" +
                                                        "&scope=" + oAuthModel.Scope + "" +
                                                        "&client_id=" + HttpUtility.UrlEncode(oAuthModel.ClientId) +
                                                        "&client_secret=" + HttpUtility.UrlEncode(oAuthModel.ClientSecret));
        }

        #endregion Supporting Methods
    }
}