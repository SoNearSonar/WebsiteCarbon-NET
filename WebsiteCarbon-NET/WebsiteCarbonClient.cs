using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Refit;
using WebsiteCarbon_NET.Models;

namespace WebsiteCarbon_NET
{
    public class WebsiteCarbonClient : IWebsiteCarbonClient
    {
        public static RefitSettings Settings = new RefitSettings()
        {
            ContentSerializer = new NewtonsoftJsonContentSerializer(new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            })
        };

        private readonly IWebsiteCarbonClient _client;

        public WebsiteCarbonClient()
        {
            _client = RestService.For<IWebsiteCarbonClient>("https://api.websitecarbon.com", Settings);
        }

        public async Task<WebsiteCarbon> GetWebsiteInformationAsync(string url)
        {
            return await _client.GetWebsiteInformationAsync(url);
        }

        public async Task<WebsiteCarbon> GetDataInBytesInformationAsync(uint bytes, uint isGreen)
        {
            return await _client.GetDataInBytesInformationAsync(bytes, isGreen);
        }
    }
}
