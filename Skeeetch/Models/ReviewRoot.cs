using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skeeetch.Models
{
    public class ReviewRoot
    {
       public IEnumerable<Review> Reviews { get; set; }
    }
}