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
        [Route("/api/material/edit/{id:int}")]
        public Material Find(int id)
        {
            return Database.Materialy.Find(t => t.Id == id);
        }

        [HttpPost]
        [Route("/api/material/add")]
        public void Add(Material material)
        {
            Database.AddMaterial(material);
        }

        [HttpPost]
        [Route("/api/material/save")]
        public void Save(Material material)
        {
            Database.EditMaterial(material);
        }

        [HttpGet]
        [Route("/api/material/list")]
        public Material[] List()
        {
            return Database.Materialy.ToArray();
        }
    }
}