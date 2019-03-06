using System.Collections.Generic;

namespace Skeeetch.Data
{
    public class Keyword
    {
        public int ID { get; set; }
        public string DisplayTerm { get; set; }
        public string SearchTerm { get; set; }

        public virtual ICollection<Keyword> Keywords { get; set; }
    }
}