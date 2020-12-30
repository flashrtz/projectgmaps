using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectgmaps.Models
{
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {

        }
        public DbSet<User> UserRegistration { get; set; }
        public DbSet<UserBuyer> UserBuyer { get; set; }

        public DbSet<FarmerLocation> FarmerLocation { get; set; }

    //    public List<FarmerLocation> FarmerLocation { get; set; }

    }
}
