using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;



namespace WebApplication2.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        Player Login(string name, string difficulty);

        bool UserExists(string name);
    }
}
