using Skeeetch.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Skeeetch.Data
{
    public class SkeeetchDbInitializer : CreateDatabaseIfNotExists<SkeeetchContext>
    {
        protected override void Seed(SkeeetchContext context)
        {
            var keywords = new List<Keyword>
            {
                new Keyword{ID = 1, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 2, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 3, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 4, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 5, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 6, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 7, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 8, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 9, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 10, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 11, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 12, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 13, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 14, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 15, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 16, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 17, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 18, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 19, DisplayTerm = "", SearchTerm = ""},
                new Keyword{ID = 20, DisplayTerm = "", SearchTerm = ""}
            };

            keywords.ForEach(k => context.Keywords.Add(k));
            context.SaveChanges();
        }
    }
}