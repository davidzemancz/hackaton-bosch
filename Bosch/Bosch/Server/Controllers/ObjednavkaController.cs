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
    public class ObjednavkaController : ControllerBase
    {
        [HttpGet]
        [Route("/api/objednavka/list")]
        public List<Objednavka> List()
        {
            return Database.Objednavky;
        }

        [HttpPost]
        [Route("/api/objednavka/save")]
        public void Save(Objednavka objednavka)
        {
			objednavka.Id = Database.Objednavky.Count > 0 ? Database.Objednavky.Max(o => o.Id) + 1 : 0;
            objednavka.Mezisklad = Database.Mezisklady.First(m => m.Id == objednavka.Mezisklad.Id);
            objednavka.Material = Database.Materialy.First(m => m.Id == objednavka.Material.Id);

			string dnes = DenVTydnu();
			List<JizdniRad> DnesniJizdniRady = new List<JizdniRad>();
			List<Jizda> DnesniJizdy = new List<Jizda>();

			foreach (var JizdniRad in Database.JizdniRady)
			{
				if (JizdniRad.Platnost.Contains(dnes))
				{
					DnesniJizdniRady.Add(JizdniRad);
					foreach (var Jizda in JizdniRad.Jizdy)
					{
						if (Jizda.CasOdjezdu.TimeOfDay > DateTime.Now.TimeOfDay)
							DnesniJizdy.Add(Jizda);
					}
				}
			}
			DnesniJizdy = DnesniJizdy.OrderBy(p => p.CasOdjezdu).ToList();

			foreach (var Jizda in DnesniJizdy)
			{
				if(Jizda.Trasa.Zastavky.FirstOrDefault(z => z.Mezisklad.Id == objednavka.Mezisklad.Id ) != null)
				{
					Jizda.Naklad.Add(objednavka.Material);
					break;
				}
            }
            Database.Objednavky.Add(objednavka);
        }


		public string DenVTydnu()
		{
			DayOfWeek dnes = DateTime.Today.DayOfWeek;
			switch (dnes)
			{
				case DayOfWeek.Monday: return "Po";
				case DayOfWeek.Tuesday: return "Út";
				case DayOfWeek.Wednesday: return "St";
				case DayOfWeek.Thursday: return "Čt";
				case DayOfWeek.Friday: return "Pá";
				case DayOfWeek.Saturday: return "So";
				case DayOfWeek.Sunday: return "Ne";
				default: return "";
			}
		}
	}
}
