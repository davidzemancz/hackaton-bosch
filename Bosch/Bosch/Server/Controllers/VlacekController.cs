using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VlacekController : ControllerBase
    {
        public static List<Material> Materialy = new List<Material>() { new Material() { Id = 1},
                                                                        new Material() { Id = 2},
                                                                        new Material() { Id = 3}};

        public static Vlacek[] Seznam = new Vlacek[]
            {


                new Vlacek() { Id = 0, Kapacita = 20, Naklad = Materialy },
                new Vlacek() { Id = 1,  Kapacita = 50, Naklad = Materialy },
                new Vlacek() { Id = 2,  Kapacita = 100, Naklad = Materialy },
                // TODO v inicializaci vláčku číslo trasy na které jezdí
            };

        [HttpGet]
        [Route("/api/vlacek/list")]
        public Vlacek[] List()
        {
            return Seznam;
        }
    }
}
