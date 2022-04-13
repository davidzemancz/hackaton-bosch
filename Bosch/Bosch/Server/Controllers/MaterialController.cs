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
        public Material Find(int Id)
        {
            return Database.Materialy.ToArray()[0];
            //TODO zmenit a volat podle use case formy
        }

        [HttpPost]
        [Route("/api/material/add")]
        public void Add(Material material)
        {
            //Database.AddMaterial(material);
            //TODO AddMaterial
        }


        [HttpGet]
        [Route("/api/material/list")]
        public Material[] List()
        {
            return Database.Materialy.ToArray();
        }
    }
}