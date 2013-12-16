using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reports911
{
    class RandomFactory
    {
        private static Random rnd = new Random();
        public static List<string> BASE_STATION_NAMES = new List<string>(){
            "Ekonomikum",
            "Matematikum",
            "Uppsala Slott",
            "Domkyrkan",
            "Pollacksbacken",
            "Engelska parken",
            "SLU"
        };
        public static List<string> EMT_NAMES = new List<string>(){
            "Räddningspatrullen",
            "Hundpatrullen",
            "Gosskören",
            "Bagarna",
            "Universitetsutryckningen"
        };
        public static List<string> INCIDENT_DESCRIPTIONS = new List<string>(){
            "En hund har fastnat i ett träd!",
            "Hjälp det brinner!",
            "Det är ett bankrån!",
            "Omg någon rånar banken",
            "Banken, banken, banken!",
            "Det brinner i grannhuset"};

        public static string EmtName()
        {
            return EMT_NAMES[rnd.Next(0, EMT_NAMES.Count - 1)];
        }

        public static string BaseStationName()
        {
            return BASE_STATION_NAMES[rnd.Next(0, BASE_STATION_NAMES.Count - 1)];
        }

        public static string IncidentDescription()
        {
            return INCIDENT_DESCRIPTIONS[rnd.Next(0, INCIDENT_DESCRIPTIONS.Count - 1)];
        }

        public static bool Bool()
        {
            return rnd.Next(0, 100) > 50;
        }
        public static int Number(int min, int max)
        {
            return rnd.Next(min, max);
        }
    }
}
