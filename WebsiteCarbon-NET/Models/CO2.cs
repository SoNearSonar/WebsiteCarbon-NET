using Newtonsoft.Json;

namespace WebsiteCarbon_NET.Models
{
    public class CO2
    {
        [JsonProperty(PropertyName = "grid")]
        public Grid Grid { get; set; } = default!;

        [JsonProperty(PropertyName = "renewable")]
        public Renewable Renewable { get; set; } = default!;
    }
}
