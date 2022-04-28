using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIxelBattle
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }
        public DbSet<LogClass> LogClasses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FAQdb;Trusted_Connection=True;");
            optionsBuilder.UseSqlite(@"Filename=PIB.db;Cache=Shared;");
        }
    }
}
