using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.Shared
{
    public class Jizda
    {
        public int Id { get; set; }

        public Vlacek Vlacek { get; set; }

        public DateTime Cas { get; set; }

        public object Trasa { get; set; }
    }

    public class JizdniRad
    {
        public int Id { get; set; }

        public string Nazev { get; set; }

        public string Platnost { get; set; }

        public List<Jizda> Jizdy { get; set; } = new List<Jizda>();
    }
}
