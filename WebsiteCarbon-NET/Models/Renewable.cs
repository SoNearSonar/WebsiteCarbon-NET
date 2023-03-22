using Newtonsoft.Json;

namespace WebsiteCarbon_NET.Models
{
    public class Renewable
    {
        /// <summary>
        ///   The approximate amount of CO2 transferred on each page load in grams
        /// </summary>
        [JsonProperty(PropertyName = "grams")]
        public double Grams { get; set; } = default!;

        /// <summary>
        ///   The approximate amount of CO2 transferred on each page load in litres
        /// </summary>
        [JsonProperty(PropertyName = "litres")]
        public double Litres { get; set; } = default!;
    }
}
