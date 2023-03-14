using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;
using WebsiteCarbon_NET.Models;

namespace WebsiteCarbon_NET.Tests
{
    [TestClass]
    public class WebsiteCarbon_NET_Test
    {
        [TestMethod]
        public void TestGetWebsiteInformation_ValidURL_ReturnsJsonObject()
        {
            WebsiteCarbonClient client = new WebsiteCarbonClient();
            WebsiteCarbon carbon = client.GetWebsiteInformationAsync("https://github.com/").Result;
            Assert.IsNotNull(carbon);
            Assert.IsTrue(carbon.Url.Equals("https://github.com/"));
            Assert.IsNotNull(carbon.Bytes);
            Assert.IsNotNull(carbon.Green);
            Assert.IsNotNull(carbon.Statistics);
            Assert.IsNotNull(carbon.Statistics.CO2);
            Assert.IsNotNull(carbon.Statistics.CO2.Grid);
            Assert.IsNotNull(carbon.Statistics.CO2.Renewable);
            Assert.IsNotNull(carbon.Timestamp);
        }

        [TestMethod]
        public void TestGetWebsiteInformation_InvalidURL_ThrowsError()
        {
            WebsiteCarbonClient client = new WebsiteCarbonClient();

            try
            {
                WebsiteCarbon carbon = client.GetWebsiteInformationAsync("https://fake-github-website.gh/").Result;
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is AggregateException);
                Assert.IsTrue((ex as AggregateException).InnerException is ApiException);
            }
        }

        [TestMethod]
        public void TestGetDataInformation_ValidBytesAndGreen_ReturnsJsonObject()
        {
            WebsiteCarbonClient client = new WebsiteCarbonClient();
            WebsiteCarbon carbon = client.GetDataInformationAsync(100, 1).Result;
            Assert.IsNotNull(carbon);
            Assert.IsNotNull(carbon.CleanerThan);
            Assert.IsNotNull(carbon.Statistics);
            Assert.IsNotNull(carbon.Statistics.CO2);
            Assert.IsNotNull(carbon.Statistics.CO2.Grid);
            Assert.IsNotNull(carbon.Statistics.CO2.Renewable);
            Assert.IsNotNull(carbon.Timestamp);
        }
    }
}