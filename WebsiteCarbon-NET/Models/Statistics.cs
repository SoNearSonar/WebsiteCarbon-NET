using Newtonsoft.Json;

namespace WebsiteCarbon_NET.Models
{
    public class Statistics
    {
        [JsonProperty(PropertyName = "adjustedBytes")]
        public double AdjustedBytes { get; set; } = default!;

        [JsonProperty(PropertyName = "energy")]
        public double Energy { get; set; } = default!;

        [JsonProperty(PropertyName = "co2")]
        public CO2 CO2 { get; set; } = default!;
    }
}
