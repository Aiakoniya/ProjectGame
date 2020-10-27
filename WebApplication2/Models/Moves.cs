using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Moves
    {
        public Guid Id { get; set; }
        public int MovesNum { get; set; }
        public Guid PlayerId { get; set; }
        public Player PlayerScore { get; set; }
    }
}
