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
	public class ZastavkaController : ControllerBase
	{
		[HttpGet]
        [Route("/api/zastavka/list")]
		public List<Zastavka> List()
		{
			return Database.Zastavky;
		}
	}
}
