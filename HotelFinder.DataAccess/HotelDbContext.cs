using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "Server=VODVIL\\SQLEXPRESS;Database=HotelDb;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
