using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VlacekController : ControllerBase
    {
        public static Vlacek[] Seznam = new Vlacek[]
            {
                new Vlacek() { Id = 0, Kapacita = 20 },
                new Vlacek() { Id = 1,  Kapacita = 50 },
                new Vlacek() { Id = 2,  Kapacita = 100 },
            };

        [HttpGet]
        [Route("/api/vlacek/list")]
        public Vlacek[] List()
        {
            return Seznam;
        }
    }
}
