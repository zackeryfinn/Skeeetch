using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skeeetch.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string YelpId { get; set; }
        public string ReviewText { get; set; }

    }
}