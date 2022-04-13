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

        public static List<Material> Materialy { get; set; } = new List<Material>
        {
            new Material() {Id = 1, Nazev = "Uhli"},
            new Material() {Id = 2, Nazev = "Srouby"},
            new Material() {Id = 3, Nazev = "lidi"},
        };

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
                new Trasa() { Id = 0, Jmeno = "Krátká", Zastavky = Zastavky },

                new Trasa() { Id = 1, Jmeno = "Dlouhá",  Zastavky = Zastavky },

                new Trasa() { Id = 2, Jmeno = "Víkendová",  Zastavky = Zastavky }
            };

        public static List<JizdniRad> JizdniRady { get; set; } = new List<JizdniRad>
        {
            new JizdniRad() { Id = 1, Nazev = "Všední dny", Platnost = "Po, Út, St, Čt, Pá", Jizdy = new List<Jizda>
            {
                new Jizda() { Id = 0, Trasa = Trasy[0], Vlacek = Vlacky[0]  },
                new Jizda() { Id = 1, Trasa = Trasy[1], Vlacek = Vlacky[1]  }
            } 
            },
        };


    }
}
