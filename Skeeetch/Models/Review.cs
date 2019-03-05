using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skeeetch.Models
{
    public class Review
    {
        [JsonProperty("id")]
        public string YelpId { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}