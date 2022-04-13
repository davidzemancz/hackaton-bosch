using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
            objednavka.Id = Database.Objednavky.Max(o => o.Id) + 1;
            objednavka.Mezisklad = Database.Mezisklady.First(m => m.Id == objednavka.Mezisklad.Id);
            objednavka.Material = Database.Materialy.First(m => m.Id == objednavka.Material.Id);
            Database.Objednavky.Add(objednavka);
        }
    }
}
