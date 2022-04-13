using Bosch.Shared;
using System.Collections.Generic;

namespace Bosch.Server
{
    public class Database
    {
        public List<Vlacek> Vlacky { get; set; } = new List<Vlacek>();

        public List<Material> Materialy { get; set; } = new List<Material>();

        public List<JizdniRad> JizdniRady { get; set; } = new List<JizdniRad>();

        public List<Mezisklad> Mezisklady { get; set; } = new List<Mezisklad>();
    }
}
