using Bosch.Shared;
using System;
using System.Collections.Generic;

namespace Bosch.Server
{
    public class Database
    {
        public static List<Vlacek> Vlacky { get; set; } = new List<Vlacek>();

        public static List<Material> Materialy { get; set; } = new List<Material>();

        public static List<JizdniRad> JizdniRady { get; set; } = new List<JizdniRad>();

        public static List<Mezisklad> Mezisklady { get; set; } = new List<Mezisklad>();

        public static List<Trasa> Trasy = new List<Trasa>
            {
                new Trasa() { Id = 0, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2008, 5, 1, 8, 30, 52) } } },

                new Trasa() { Id = 1, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2020, 8, 1, 8, 30, 52) } } },

                new Trasa() { Id = 2, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2022, 5, 10, 8, 30, 52) } } },
            };
    }
}
