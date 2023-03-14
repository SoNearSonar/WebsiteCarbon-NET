﻿using Newtonsoft.Json;

namespace WebsiteCarbon_NET.Models
{
    public class Grid
    {
        [JsonProperty(PropertyName = "grams")]
        public double Grams { get; set; } = default!;

        [JsonProperty(PropertyName = "litres")]
        public double Litres { get; set; } = default!;
    }
}
