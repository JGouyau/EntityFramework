using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class MyContext: DbContext 
    {
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MyContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
