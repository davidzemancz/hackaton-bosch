using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VlacekController : ControllerBase
    {
        [HttpGet]
        [Route("/api/vlacek/list")]
        public Vlacek[] List()
        {
            return Database.Vlacky.ToArray();
        }
    }
}
