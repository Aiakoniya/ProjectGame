using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Repositories.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication2.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DataContext _context;

        public PlayerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddPlayer(Player p)
        {
            _context.PlayerList.Add(p);
            return (await _context.SaveChangesAsync()) > 0;
        }
        public async Task<IEnumerable<Player>> GetPlayers()
        {

            return await _context.PlayerList.Include(x => x.PlayerScore).ToListAsync();
        }
    }
}
