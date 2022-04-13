using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bosch.Shared;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrasaController : ControllerBase
    {

        [HttpGet]
        [Route("/api/trasa/list")]
        public List<Trasa> List()
        {
            return Database.Trasy;
        }

        [HttpGet]
        [Route("/api/trasa/edit/{id:int}")]
        public Trasa Edit(int id)
        {
            if (id == -1) return new Trasa();
            return Database.Trasy.First(t => t.Id == id);


        }
        [HttpPost]
        [Route("/api/trasa/save")]
        public void Save(Trasa trasa)
        {
            if (trasa.Id == -1)
            {
                trasa.Id = Database.Trasy.Max(o => o.Id) + 1;
                Database.Trasy.Add(trasa);
            }
            else
            {
                Database.Trasy[Database.Trasy.FindIndex(t => t.Id == trasa.Id)] = trasa;
            }
        }
        [HttpPost]
        [Route("/api/trasa/remove/{id:int}")]
        public void Remove(int id)
        {
            Database.RemoveTrasa(id);
        }
    }
}
