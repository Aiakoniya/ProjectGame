using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace WebApplication2.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }

        public Player Login(string name, string difficulty)
        {
            var player = _context.PlayerList.FirstOrDefault(x => x.Name == name);
            return player;
        }

        public bool UserExists(string name)
        {
            return _context.PlayerList.Any(x => x.Name == name);
        }
    } 
}
