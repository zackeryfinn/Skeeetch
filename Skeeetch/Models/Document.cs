using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skeeetch.Models
{
    public class Document
    {
        [JsonProperty("id")]
        public string YelpId { get; set; }
        public List<string> KeyPhrases { get; set; }        
    }
}