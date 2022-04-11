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
                new Vlacek() { Id = 0, Typ = "Nakladni", Material = "Uhli", Kapacita = 20 },
                new Vlacek() { Id = 1, Typ = "Nakladni", Material = "Drevo", Kapacita = 50 },
                new Vlacek() { Id = 2, Typ = "Osobni", Material = "Lidi", Kapacita = 100 },
            };

        [HttpGet]
        [Route("/api/vlacek/list")]
        public Vlacek[] List()
        {
            return Seznam;
        }
    }
}
