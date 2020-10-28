using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.DTOs;

namespace WebApplication2.Models
{
    public class Player
    {
        public Player()
        {

        }

        public Player(PlayerDto p)
        {
            ID = Guid.NewGuid();
            Name = p.Name;
            Difficulty = p.Difficulty;
            MovesId = p.MovesId;
    }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public Guid MovesId { get; set; }
        public Guid PlayerScore { get; set; }
    }
}
