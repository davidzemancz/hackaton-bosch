using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JizdniRadController : ControllerBase
    {
        [HttpGet]
        [Route("/api/jizdnirad/list")]
        public List<JizdniRad> List()
        {
            return Database.JizdniRady;
        }

        [HttpGet]
        [Route("/api/jizdnirad/edit/{id:int}")]
        public JizdniRad Edit(int id)
        {
            return Database.JizdniRady.First(t => t.Id == id);
        }

    }
}
