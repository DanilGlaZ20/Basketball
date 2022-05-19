using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Basketball.Models;
namespace Basketball.Controllers
{
    [ApiController]
    [Route("/api/clubs")]
    
    public class ClubController : ControllerBase
    {
        private List<Club> Club { get; set; }

        public ClubController()
        {
            Club = new List<Club>()
            {
                new Club() {Id = 1, Title = "Павел Александрович САМЫЙ ЛУЧШИЙ",Number_Person = 15, Budget = 9999999},
                new Club() {Id = 1, Title = "Timberwolvs",Number_Person = 12, Budget = 1010101010},
                new Club() {Id = 1, Title = "Bulls",Number_Person = 13, Budget = 64353453},
                new Club() {Id = 1, Title = "Khimki",Number_Person = 10, Budget = 0},
                new Club() {Id = 1, Title = "Rockets",Number_Person =11, Budget = 100500}
                
                    
            };
        }
        [HttpGet]
        public ActionResult GetAllClub()
        {
            return Ok(Club);
        }
    }
}