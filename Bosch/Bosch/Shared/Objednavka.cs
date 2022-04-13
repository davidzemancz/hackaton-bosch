using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.Shared
{
    public class Objednavka
    {
        public int Id { get; set; }
        public Mezisklad Mezisklad { get; set; }  = new Mezisklad();
        public Material Material { get; set; } = new Material();
    }
}
