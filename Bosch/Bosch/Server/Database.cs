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

        public static List<Mezisklad> Mezisklady { get; set; } = new List<Mezisklad>()
        {
            new Mezisklad { Id = 0, Jmeno = "Praha", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 1, Jmeno = "Brno", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 2, Jmeno = "Ostrava", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 3, Jmeno = "Liberec", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 4, Jmeno = "Olomouc", jizdniRad = null, seznamVlacku = { } },
            new Mezisklad { Id = 5, Jmeno = "Pardubice", jizdniRad = null, seznamVlacku = { } },
        };

        public static List<Zastavka> Zastavky { get; set; } = new List<Zastavka>()
        {
            new Zastavka() {
                Mezisklad = Mezisklady[0], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[1], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[2], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[3], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[4], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },
            new Zastavka() {
                Mezisklad = Mezisklady[5], Cas = new DateTime(2008, 5, 1, 8, 30, 52) },

        };

        public static List<Trasa> Trasy = new List<Trasa>
            {
                new Trasa() { Id = 0, Zastavky = Zastavky },

                new Trasa() { Id = 1, Zastavky = Zastavky },

                new Trasa() { Id = 2, Zastavky = Zastavky }
            };
    }
}
