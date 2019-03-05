using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skeeetch.Models
{
    public class Location
    {
        [JsonProperty("adress1")]
        public string Adress { get; set; }
        public string City { get; set; }
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
        public string State { get; set; }
        [JsonProperty("display_address")]
        public List<string> DisplayAddress { get; set; }
    }
}