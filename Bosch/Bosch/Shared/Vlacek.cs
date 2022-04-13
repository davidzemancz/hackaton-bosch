using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.Shared
{
    public class Vlacek
    {
        public int Id { get; set; }
        public string sapID { get; set; }
        public int Kapacita { get; set; }
        public List<Material> Naklad { get; set; }
        //TODO: zastavky, jizdni rad


    }
}
