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

        [HttpDelete]
        [Route("/api/vlacek/remove/{id:int}")]
        public void Remove(int id)
        {
            Database.RemoveVlacek(Database.Vlacky.Find(t => t.Id == id));
        }

    }
}
