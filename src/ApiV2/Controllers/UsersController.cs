using Microsoft.AspNetCore.Mvc;

namespace ApiV2.Controllers
{
	[Route("api/v2/users")]
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
					fullName = "User One",
					upn = "user1@foo.com"
				},
				new
				{
					name = "User2",
					fullName = "User Two",
					upn = "user2@foo.com"
				}
			});
        }
    }
}
