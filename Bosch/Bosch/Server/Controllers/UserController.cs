using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Bosch.Server.Controllers
{
    
    [Route("/api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        [Route("/api/uzivatel/list")]
        public Uzivatel[] List()
        {
            return Database.Uzivatele.ToArray();
        }

        [HttpGet]
        [Route("/api/uzivatel/edit/{id:int}")]
        public Uzivatel Edit(int id)
        {
            return Database.Uzivatele.Find(u => u.Id == id);
        }

        [HttpPost]
        [Route("/api/uzivatel/save")]
        public void Save(Uzivatel uzivatel)
        {
            Database.EditUzivatel(uzivatel);
        }

        [HttpPost]
        [Route("/api/uzivatel/add")]
        public void Add(Uzivatel uzivatel)
        {
            Database.AddUzivatel(uzivatel);
        }

        [HttpPost]
        [Route("/api/uzivatel/remove")]
        public void Remove(int id)
        {
            // Database.RemoveVlacek(Database.Vlacky.Find(t => t.Id == id));
        }

    }
}
