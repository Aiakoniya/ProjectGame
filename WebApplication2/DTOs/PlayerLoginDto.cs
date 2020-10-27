using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.DTOs
{
    public class PlayerLoginDto
    {
        [Required]
        public string Name { get; set; }
        public string Difficulty { get; set; }
    }
}
