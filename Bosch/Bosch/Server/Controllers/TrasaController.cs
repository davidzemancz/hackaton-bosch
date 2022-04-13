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
        public static Trasa[] Trasy = new Trasa[]
            {
                new Trasa() { Id = 0, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2008, 5, 1, 8, 30, 52) } } },

                new Trasa() { Id = 1, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2020, 8, 1, 8, 30, 52) } } },

                new Trasa() { Id = 2, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2022, 5, 10, 8, 30, 52) } } },
            };

        [HttpGet]
        [Route("/api/trasa/list")]
        public Trasa[] List()
        {
            return Trasy;
        }
    }
}
