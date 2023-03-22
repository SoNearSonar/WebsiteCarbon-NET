using Newtonsoft.Json;

namespace WebsiteCarbon_NET.Models
{
    public class CO2
    {
        /// <summary>
        ///   The approximate amount of CO2 transferred from a non-renewable power source
        /// </summary>
        [JsonProperty(PropertyName = "grid")]
        public Grid Grid { get; set; } = default!;

        /// <summary>
        ///   The approximate amount of CO2 transferred from a renewable power source
        /// </summary>
        [JsonProperty(PropertyName = "renewable")]
        public Renewable Renewable { get; set; } = default!;
    }
}
