using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HelloAngularJS_EF.Core.Domain.Models;

namespace HelloAngularJS_EF.Core.Infrastructure.DAL
{
    public class MeetUpContext : DbContext
    {
        public MeetUpContext() : base("Data Source=tlc-dev-sql01;Initial Catalog=MeetUp;Integrated Security=True")
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Admin");

            //modelBuilder.Entity<User>().ToTable("dbo.RegisteredUser");
            modelBuilder.Entity<User>().Map(m => {
                m.Properties(p => new { p.Name.FirstName,
                    p.Name.LastName,
                    p.ID,
                    p.Username,
                    p.DisplayName,
                    p.Email,
                    p.Contact });
                m.ToTable("dbo.RegisteredUser");
            });
            modelBuilder.Entity<User>().Property(x => x.Name.LastName).HasColumnName("LastName");
            modelBuilder.Entity<User>().Property(x => x.Name.FirstName).HasColumnName("FirstName"); 
        }
    }
}