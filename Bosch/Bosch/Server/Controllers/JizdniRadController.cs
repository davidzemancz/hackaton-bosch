using Bosch.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Bosch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JizdniRadController : ControllerBase
    {
        
        [HttpGet]
        [Route("/api/jizdnirad/jizdy")]
        public List<Jizda> GetJizdy()
        {
           return Database..Jizdy;
        }
    }
}
