using Microsoft.AspNetCore.Mvc;

namespace Altaliza.API.Controllers
{
    [Route("")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet]
        public void Get()
        {
            Response.Redirect("swagger");
        }
    }
}
