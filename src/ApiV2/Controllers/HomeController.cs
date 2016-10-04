using Microsoft.AspNetCore.Mvc;

namespace ApiV2.Controllers
{
	[Route("api/v2")]
    public class HomeController
		: Controller
    {
		[HttpGet("")]
        public IActionResult Index()
        {
            return Ok("Hello from API v2.");
        }
    }
}
