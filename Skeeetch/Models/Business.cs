using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skeeetch.Models
{
    public class Business
    {
        public int Id { get; set; }
        public string YelpId { get; set; }
        public string Location { get; set; }
        public string Name { get; set;}
        public string Image_url { get; set; }
        public string Price { get; set; }
        public string[] Hours { get; set; }
        
    }
}