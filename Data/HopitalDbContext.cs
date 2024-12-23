using Microsoft.EntityFrameworkCore;
using HopitalAPI.Models;
using System.Collections.Generic;

namespace HopitalAPI.Data
{
    public class HopitalDbContext : DbContext
    {
        public HopitalDbContext(DbContextOptions<HopitalDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
    }
}
