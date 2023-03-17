using Refit;
using WebsiteCarbon_NET.Models;

namespace WebsiteCarbon_NET
{
    [Headers("User-Agent: WebsiteCarbon-NET/1.0", "Content-Type: application/json")]
    public interface IWebsiteCarbonClient
    {
        [Get("/site?url={url}")]
        Task<WebsiteCarbon> GetWebsiteInformationAsync(string url);

        [Get("/data?bytes={bytes}&green={isGreen}")]
        Task<WebsiteCarbon> GetDataInBytesInformationAsync(uint bytes, uint isGreen);
    }
}