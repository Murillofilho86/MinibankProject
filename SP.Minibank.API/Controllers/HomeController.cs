using Microsoft.AspNetCore.Mvc;

namespace SP.Minibank.API.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public string Get()
        {
            return "Hello World";
        }

    }
}