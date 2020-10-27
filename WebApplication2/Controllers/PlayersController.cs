using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.DTOs;
using WebApplication2.Models;
using WebApplication2.Repositories;
using WebApplication2.Repositories.Interfaces;

namespace WebApplication2.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayersController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [Authorize(Roles = Role.Administrator)]
        [HttpGet]
        public async Task<ActionResult<ICollection<PlayerDto>>> GetPlayers()
        {
            IEnumerable<Player> innerPlayers = await _playerRepository.GetPlayers();
            ICollection<PlayerDto> players = new LinkedList<PlayerDto>();

            foreach(Player p in innerPlayers)
            {
                players.Add(new PlayerDto()
                {
                    Name = p.Name,
                    Difficulty = p.Difficulty,
                    MovesId = p.MovesId
                });
            }
            return Ok(players);
        }
        //return _playerRepository.GetPlayers();
        [HttpPost]
        public async Task<ActionResult> AddPlayer(PlayerDto p)
        {

            Player pl = new Player();
            if (await _playerRepository.AddPlayer(pl))
            {
                return Ok("A new player was added successfully!");
            }

            return BadRequest("Oops, something went wrong!");
        }
    }
}
