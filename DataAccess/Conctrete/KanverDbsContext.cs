using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Conctrete
{
    public class KanverDbsContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=KanverDbs.mssql.somee.com;packet size=4096;user id=ganxboy_SQLLogin_1;pwd=bhaelxywxr;data source=KanverDbs.mssql.somee.com;persist security info=False;initial catalog=KanverDbs");
        }
    }
}