using System.Collections.Generic;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Conctrete
{
    internal class KanverDbsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;" +
                                        "Database = kanver;" +
                                        "Trusted_Connection=true");
        }

        public List<Announcement> Announcements { get; set; }
        public List<AnnouncementType> AnnouncementTypes { get; set; }
        public List<BloodType> BloodTypes { get; set; }
        public List<City> Cities { get; set; }
        public List<DonationPoint> DonationPoints { get; set; }
        public List<Donor> Donors { get; set; }
        public List<User> Users { get; set; }
    }
}