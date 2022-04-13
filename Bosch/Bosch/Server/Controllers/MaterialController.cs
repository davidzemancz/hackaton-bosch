using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        [HttpGet]
        [Route("/api/vlacek/edit/{id:int}")]
        public void Find(int Id)
        {
            //TODO
        }

        [HttpGet]
        [Route("/api/vlacek/list")]
        public Vlacek[] List()
        {
            return Database.Vlacky.ToArray();
        }
    }
}