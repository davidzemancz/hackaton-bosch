using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

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
            return Database.Vlacky.ToArray();
        }

        [HttpGet]
        [Route("/api/vlacek/edit/{id:int}")]
        public Vlacek Edit(int id)
        {
            return Database.Vlacky.Find(t => t.Id == id);
        }

        [HttpPost]
        [Route("/api/vlacek/save")]
        public void Save(Vlacek vlacek)
        {
            Database.EditVlacek(vlacek);
        }

        [HttpPost]
        [Route("/api/vlacek/remove")]
        public void Remove(int id)
        {
            Database.RemoveVlacek(Database.Vlacky.Find(t => t.Id == id));
        }

    }
}
