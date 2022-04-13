using Bosch.Shared;
using System;
using System.Collections.Generic;

namespace Bosch.Server
{
    public class Database
    {
        public static List<Vlacek> Vlacky { get; set; } = new List<Vlacek>
        {
            new Vlacek() { Id = 0, Jmeno = "A", Kapacita = 20 },
            new Vlacek() { Id = 1, Jmeno = "B",  Kapacita = 50 },
            new Vlacek() { Id = 2, Jmeno = "C",  Kapacita = 100 },
        };

        public static void EditVlacek(Vlacek vlacek)
        {
            int index = Vlacky.FindIndex(v => v.Id == vlacek.Id);
            Vlacky[index] = vlacek;
        }

        public static void RemoveVlacek(Vlacek vlacek)
        {
            Vlacky.Remove(vlacek);
        }

        public static void AddVlacek(Vlacek vlacek)
        {
            int maxIndex = Vlacky[Vlacky.Count - 1].Id;
            vlacek.Id = maxIndex + 1;

            Vlacky.Add(vlacek);

        }

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
