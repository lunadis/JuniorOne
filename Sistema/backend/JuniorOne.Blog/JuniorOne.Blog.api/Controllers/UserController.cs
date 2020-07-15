using Microsoft.AspNetCore.Mvc;

namespace JuniorOne.Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Teste()
        {
            return Ok("teste");
        }
    }
}