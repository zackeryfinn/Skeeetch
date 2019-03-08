using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skeeetch.Models
{
    public class DocumentRoot
    {
        public IEnumerable<Document> Documents { get; set; }
    }
}