using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.Shared
{
	public class Zastavka
	{
		public Mezisklad Mezisklad { get; set; }
		public DateTime Cas { get; set; }
	}
	public class Trasa
	{
		public int Id { get; set; }
		public List<Zastavka> Zastavky { get; set; }


	}
}
