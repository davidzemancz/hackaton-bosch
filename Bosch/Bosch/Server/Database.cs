using Bosch.Shared;
using System;
using System.Collections.Generic;

namespace Bosch.Server
{
    public class Database
    {
        public static List<Vlacek> Vlacky { get; set; } = new List<Vlacek>
        {
            new Vlacek() { Id = 0, Kapacita = 20 },
            new Vlacek() { Id = 1,  Kapacita = 50 },
            new Vlacek() { Id = 2,  Kapacita = 100 },
        };

        public static List<Trasa> Trasy = new List<Trasa>
            {
                new Trasa() { Id = 0, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2008, 5, 1, 8, 30, 52) } } },

                new Trasa() { Id = 1, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2020, 8, 1, 8, 30, 52) } } },

                new Trasa() { Id = 2, Zastavky = new List<Zastavka> {
                    new Zastavka() { Mezisklad = null, Cas = new DateTime(2022, 5, 10, 8, 30, 52) } } },
            };

        public static List<Material> Materialy { get; set; } = new List<Material>();

        public static List<JizdniRad> JizdniRady { get; set; } = new List<JizdniRad>
        {
            new JizdniRad() { Id = 1, Nazev = "Všední dny", Platnost = "Po, Út, St, Čt, Pá", Jizdy = new List<Jizda>
            {
                new Jizda() { Id = 0, Trasa = Trasy[0], Vlacek = Vlacky[0]  },
                new Jizda() { Id = 1, Trasa = Trasy[1], Vlacek = Vlacky[1]  }
            } 
            },
        };

        public static List<Mezisklad> Mezisklady { get; set; } = new List<Mezisklad>();
    }
}
