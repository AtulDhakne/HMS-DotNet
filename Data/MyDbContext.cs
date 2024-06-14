using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HMS.Models;

namespace HMS.Data
{
    public class MyDbContext: IdentityDbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<HMS.Models.ContactUs>? ContactUs { get; set; }
        public DbSet<HMS.Models.Doctor>? Doctor { get; set; }

        public DbSet<HMS.DTO.RoleStore>? RoleStore { get; set; }

        public DbSet<HMS.Models.Patient>? Patient { get; set; }

        public DbSet<HMS.Models.Booking>? Booking { get; set; }
    }
}

