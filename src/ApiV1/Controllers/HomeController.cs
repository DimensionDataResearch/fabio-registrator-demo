using Microsoft.AspNetCore.Mvc;

namespace ApiV1.Controllers
{
	[Route("api/v1")]
    public class HomeController
		: Controller
    {
		[HttpGet("")]
        public IActionResult Index()
        {
            return Ok("Hello from API v1.");
        }
    }
}
