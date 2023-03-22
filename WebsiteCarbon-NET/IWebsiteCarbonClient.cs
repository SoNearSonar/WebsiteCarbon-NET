using Refit;
using WebsiteCarbon_NET.Models;

namespace WebsiteCarbon_NET
{
    /// <summary>
    ///   A client that has endpoints for calculations of carbon use for a website
    /// </summary>
    /// <remarks> Documentation: <see href="https://api.websitecarbon.com/"/> </remarks>
    [Headers("User-Agent: WebsiteCarbon-NET/1.0", "Content-Type: application/json")]
    public interface IWebsiteCarbonClient
    {
        /// <summary>
        ///   Get the carbon emission estimate for a website
        /// </summary>
        /// <param name="url">The url of the website to search</param>
        /// <remarks> Information: <see href="https://api.websitecarbon.com/#site-endpoint"/> </remarks>
        /// <exception cref="ApiException">Thrown if the url is not a valid url</exception>
        [Get("/site?url={url}")]
        Task<WebsiteCarbon> GetWebsiteInformationAsync(string url);

        /// <summary>
        ///   Get the carbon emission estimate for a number of bytes and if green status should be taken into account
        /// </summary>
        /// <param name="bytes">The number of bytes to calculate</param>
        /// /// <param name="isGreen">If the calculation should take into account being environemntally friendly</param>
        /// <remarks> Information: <see href="https://api.websitecarbon.com/#data-endpoint"/> </remarks>
        [Get("/data?bytes={bytes}&green={isGreen}")]
        Task<WebsiteCarbon> GetDataInBytesInformationAsync(uint bytes, uint isGreen);
    }
}