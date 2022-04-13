using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.Shared
{
    public class Objednavka
    {
        public Mezisklad Mezisklad { get; set; }
        public List<Material> Materialy { get; set; }
    }
}
