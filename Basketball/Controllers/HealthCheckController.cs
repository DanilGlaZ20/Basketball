using Microsoft.AspNetCore.Mvc;

namespace BasketballController
{
    
    [ApiController]
    [Route("/api")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("healthCheck")]
        public ActionResult HealthCheck()
        {
            return Ok();
        }
    }
}