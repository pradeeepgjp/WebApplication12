using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication12.Models;

namespace WebApplication12.Data
{
    public class HeroDbContext : IdentityDbContext
    {
        public HeroDbContext(DbContextOptions<HeroDbContext> options) : base(options) { }

        public DbSet<Hero> HeroList { get; set; }

    }
}
