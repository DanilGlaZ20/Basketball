using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Basketball.Models;
namespace Basketball.Controllers
{
    [ApiController]
    [Route("/api/players")]
    
    public class PlayerController : ControllerBase
        {
            private List<Player> Player { get; set; }

            public PlayerController()
            {
                Player = new List<Player>()
                {
                    new Player() {Id = 1, Name = "Jimmy Butler",Number=22,Hieght = 196},
                    new Player() {Id = 2, Name = "Tyler Hirro",Number=14,Hieght = 198},
                    new Player() {Id = 3, Name = "PJ Tacker",Number=3,Hieght = 202},
                    new Player() {Id = 4, Name = "Viktor Oladipo",Number=7,Hieght = 199},
                    new Player() {Id = 5, Name = "Bam Adebayo",Number=34,Hieght = 210},
                    
                };
            }
            [HttpGet]
            public ActionResult GetAllPlayer()
            {
                return Ok(Player);
            }
        }
    }
    