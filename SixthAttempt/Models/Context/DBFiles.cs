using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SixthAttempt.Models.DBFiles
{
    public class DBFiles : DbContext
    {
        public DBFiles() : base("name=connection")
        {

        }

        public DbSet<Farmer> farmers { get; set; }
        public DbSet<CropList> croplists { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Bidder> bidders { get; set; }
        public DbSet<Insurence> insurences { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DBFiles>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}