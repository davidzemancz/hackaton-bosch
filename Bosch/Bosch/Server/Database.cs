using Bosch.Shared;
using System.Collections.Generic;

namespace Bosch.Server
{
    public class Database
    {
        public static List<Vlacek> Vlacky { get; set; } = new List<Vlacek>();

        public static List<Material> Materialy { get; set; } = new List<Material>();

        public static List<JizdniRad> JizdniRady { get; set; } = new List<JizdniRad>();

        public static List<Mezisklad> Mezisklady { get; set; } = new List<Mezisklad>();
    }
}
