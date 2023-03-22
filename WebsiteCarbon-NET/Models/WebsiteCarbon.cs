using Newtonsoft.Json;

namespace WebsiteCarbon_NET.Models
{
    public class WebsiteCarbon
    {
        /// <summary>
        ///   The url of the website
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; } = default!;

        /// <summary>
        ///   If the website is environmentally friendly or not
        /// </summary>
        [JsonProperty(PropertyName = "green")]
        public object Green { get; set; } = default!;

        /// <summary>
        ///   The size in bytes of the website
        /// </summary>
        [JsonProperty(PropertyName = "bytes")]
        public int Bytes { get; set; } = default!;

        /// <summary>
        ///   The precentage representing how much more clean the website is compared to others
        /// </summary>
        [JsonProperty(PropertyName = "cleanerThan")]
        public decimal CleanerThan { get; set; } = default!;

        /// <summary>
        ///   An object holding the environemntal information for the entered website
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public Statistics Statistics { get; set; } = default!;

        /// <summary>
        ///   The timestamp as a number representing the time the estimation was done
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public uint Timestamp { get; set; } = default!;
    }
}
