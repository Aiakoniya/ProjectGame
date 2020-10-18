using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private List<Player>  players; //Here I create list of players
        private List<Moves> movement; //Here I create list of movements
        public PlayerController() //constructor
        {
            players = new List<Player>()
            {
                new Player(){ ID = 1, Name = "Abylai", Difficulty = "Beginner", Score = 13},
                 new Player(){ ID = 2, Name = "Aigerim", Difficulty = "Beginner", Score = 19},
                  new Player(){ ID = 3, Name = "Yelina", Difficulty = "Intermediate", Score = 10},
                   new Player(){ ID = 4, Name = "Zhomart", Difficulty = "Professional", Score = 12}, //here we added values
            };
            movement = new List<Moves>()
            {
                new Moves(){ PlayerId = 1, MovesNum = 5, PlayerScore = 13},
                new Moves(){ PlayerId = 2, MovesNum = 7, PlayerScore = 19},
                new Moves(){ PlayerId = 3, MovesNum = 6, PlayerScore = 10},
                new Moves(){ PlayerId = 4, MovesNum = 8, PlayerScore = 12},
            };
        }
        [HttpGet]   //endpoints
        public List<Player> PlayersName()
        {
            return players;
        }

        [HttpGet("PlayerId/{PlayerId}")]
        public List<Moves> Movement(int idPlayer)
        {
            return movement.Where(m => m.PlayerId == idPlayer).ToList();
        }

        [HttpGet("Difficulty/{Difficulty}")]
        public List<Player> PlayerDiff(string diff)
        {
            return players.Where(p => p.Difficulty == diff).ToList();
        }

        [HttpGet("{Name}/{Difficulty}")]
        public string InfoAbout(string Name, string Difficulty)
        {
            return "Hello, I'm " + Name + " and my level is " + Difficulty;
        }

        [HttpGet("Name/{Name}")]
        public List<Player> PlayerName(string name)
        {
            return players.Where(p => p.Name.ToLower() == name.ToLower()).ToList();
        }

    };
}
