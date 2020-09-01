using EFDemo.Model;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.EF
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class MyContext : DbContext
    {
        static string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        public MyContext() : base(conStr)
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<User> User { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserDetail>().HasRequired(x => x.User).WithMany(x => x.Detail).HasForeignKey(x => x.UserId);
        }
    }
}
