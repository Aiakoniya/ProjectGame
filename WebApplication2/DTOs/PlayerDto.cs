using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.DTOs
{
    public class PlayerDto
    {
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public Guid MovesId { get; set; }
        public int PlayerScore { get; set; }
    }
}
