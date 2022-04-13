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
            return Database.Trasy.First(t => t.Id == id);
        }
    }
}
