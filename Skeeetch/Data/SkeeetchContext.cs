using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Skeeetch.Data
{
    public class SkeeetchContext : DbContext
    {
        public SkeeetchContext() : base("SkeeetchContext")
        {
            Database.SetInitializer(new SkeeetchDbInitializer());
        }

        public DbSet<Keyword> Keywords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Skeeetch.Models.Review> Reviews { get; set; }
    }
}