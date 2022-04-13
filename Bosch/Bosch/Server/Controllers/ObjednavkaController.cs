using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjednavkaController : ControllerBase
    {
        [HttpGet]
        [Route("/api/objednavka/list")]
        public List<Objednavka> List()
        {
            return Database.Objednavky;
        }

        [HttpPost]
        [Route("/api/objednavka/save")]
        public void Save(Objednavka objednavka)
        {

        }
    }
}
