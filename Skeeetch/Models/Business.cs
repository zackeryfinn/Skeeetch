using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skeeetch.Models
{
    public class Business
    {
        [JsonProperty("id")]
        public string YelpId { get; set; }
        public string Name { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }       
        [JsonProperty("review_coun")]
        public int ReviewCount { get; set; }
        public double Rating { get; set; }
        [JsonProperty("location")]
        public Location LocationInfo { get; set; }
        [JsonProperty("display_phone")]
        public string DisplayPhone { get; set; }

    }
}