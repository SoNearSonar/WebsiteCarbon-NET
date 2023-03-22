using Newtonsoft.Json;

namespace WebsiteCarbon_NET.Models
{
    public class Statistics
    {
        /// <summary>
        ///   The approximate number of bytes transferred by the page load, adjusted to take first time vs returning visitor percentage into account.
        /// </summary>
        [JsonProperty(PropertyName = "adjustedBytes")]
        public double AdjustedBytes { get; set; } = default!;

        /// <summary>
        ///   The approximate amount of energy transferred on each page load in KWg.
        /// </summary>
        [JsonProperty(PropertyName = "energy")]
        public double Energy { get; set; } = default!;

        /// <summary>
        ///   An object containing data on the amount of CO2 transferred on each page load.
        /// </summary>
        [JsonProperty(PropertyName = "co2")]
        public CO2 CO2 { get; set; } = default!;
    }
}
