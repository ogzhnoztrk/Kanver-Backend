using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctrete
{
    public class KanverDbsContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<BloodType> BloodTypes { get; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;" +
                                        "Database = kanver;" +
                                        "Trusted_Connection=true");
        }
    }
}