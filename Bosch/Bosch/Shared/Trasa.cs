using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.Shared
{
	public class Zastavka
	{
		public Mezisklad Mezisklad { get; set; } = new Mezisklad();
		public DateTime Cas { get; set; }

		public override string ToString()
		{
			return Mezisklad?.Jmeno + ", ";
		}
	}
	public class Trasa
	{
		public int Id { get; set; }

		public string Jmeno { get; set; }
		public List<Zastavka> Zastavky { get; set; } = new List<Zastavka>();
		
	}
}
