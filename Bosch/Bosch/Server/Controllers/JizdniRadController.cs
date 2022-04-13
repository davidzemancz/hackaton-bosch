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
            if (id == -1) return new JizdniRad();
            return Database.JizdniRady.First(t => t.Id == id);
        }

        [HttpPost]
        [Route("/api/jizdnirad/save")]
        public void Save(JizdniRad jizdniRad)
        {
            if (jizdniRad.Id == -1)
            {
                jizdniRad.Id = Database.Trasy.Max(o => o.Id) + 1;
                Database.JizdniRady.Add(jizdniRad);
            }
            else
            {
                Database.JizdniRady[Database.JizdniRady.FindIndex(t => t.Id == jizdniRad.Id)] = jizdniRad;
            }
        }
    }
}
