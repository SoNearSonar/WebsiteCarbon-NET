using Newtonsoft.Json;

namespace WebsiteCarbon_NET.Models
{
    public class WebsiteCarbon
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; } = default!;

        [JsonProperty(PropertyName = "green")]
        public object Green { get; set; } = default!;

        [JsonProperty(PropertyName = "bytes")]
        public int Bytes { get; set; } = default!;

        [JsonProperty(PropertyName = "cleanerThan")]
        public decimal CleanerThan { get; set; } = default!;

        [JsonProperty(PropertyName = "statistics")]
        public Statistics Statistics { get; set; } = default!;

        [JsonProperty(PropertyName = "timestamp")]
        public uint Timestamp { get; set; } = default!;
    }
}
