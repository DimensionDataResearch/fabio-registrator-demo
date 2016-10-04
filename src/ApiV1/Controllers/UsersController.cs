using Microsoft.AspNetCore.Mvc;

namespace ApiV1.Controllers
{
	[Route("api/v1/users")]
    public class UsersController
		: Controller
    {
		[HttpGet("")]
        public IActionResult Index()
        {
            return Json(new[]
			{
				new
				{
					name = "User1",
					upn = "user1@foo.com"
				},
				new
				{
					name = "User2",
					upn = "user2@foo.com"
				}
			});
        }
    }
}
