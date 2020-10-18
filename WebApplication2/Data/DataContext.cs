using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Player> PlayerList { get; set; }
        public DbSet<Moves> Movess { get; set; }
    }
}
