namespace WebApplication2.Models
{
    public class OAuthModel
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string TenantId { get; set; }
        public string Msbaseurl { get; set; }
        public string MsEndUrl { get; set; }
        public string Scope { get; set; }
        public string MediaTypeHeaderValue { get; set; }
        public string grantType { get; set; }
    }
}