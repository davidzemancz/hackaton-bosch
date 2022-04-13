using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeziskladyController : ControllerBase
    {

        [HttpGet]
        [Route("/api/mezisklad/list")]
        public Mezisklad[] List()
        {
            return Database.Mezisklady.ToArray();
        }

        [HttpGet]
        [Route("/api/mezisklad/edit/{id:int}")]
        public Mezisklad Edit(int id)
        {
            return Database.Mezisklady.Find(t => t.Id == id);
        }


        [HttpPost]
        [Route("/api/mezisklad/add")]
        public void Add(Mezisklad mezisklad)
        {
            Database.AddMezisklad(mezisklad);
        }

        [HttpPost]
        [Route("/api/mezisklad/save")]
        public void Save(Mezisklad mezisklad)
        {
            Database.EditMezisklad(mezisklad);
        }

    }
}
