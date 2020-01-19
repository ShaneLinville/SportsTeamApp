using Microsoft.EntityFrameworkCore;
using SportsTeamApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeamApp.Data
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options)
            : base(options)
        {
           
        }

        public DbSet<Player> Player { get; set; }



    }
}
