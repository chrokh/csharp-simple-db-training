using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reports911
{
    enum RandomFactoryReturnType
    {
        BASESTATION,
        EMT,
        INCIDENT
    }

    class RandomFactory
    {
        private static Random rnd = new Random();
        private static List<string> _basestation_names = new List<string>(){
            "BS:Ekonomikum",
            "BS:Matematikum",
            "BS:Uppsala Slott",
            "BS:Domkyrkan",
            "BS:Pollacksbacken",
            "BS:Engelska parken",
            "BS:SLU",
            "BS:Konserthuset",
            "BS:Gamla stan",
            "BS:Brandstationen",
            "BS:Polisstationen",
            "BS:Ambulansstationen"
        };
        private static List<string> _emt_names = new List<string>(){
            "EMT:Räddningspatrullen",
            "EMT:Hundpatrullen",
            "EMT:Gosskören",
            "EMT:Bagarna",
            "EMT:Universitetsutryckningen",
            "EMT:Nyan Cat",
            "EMT:Team Alpha",
            "EMT:Dansbandsgänget",
            "EMT:Brandkåren",
            "EMT:Potatisgrisarna"
        };
        private static List<string> _incident_descriptions = new List<string>(){
            "I:En hund har fastnat i ett träd!",
            "I:Hjälp det brinner!",
            "I:Det är ett bankrån!",
            "I:Omg någon rånar banken",
            "I:Banken, banken, banken!",
            "I:Det brinner i grannhuset",
            "I:Elden i grannhuset blir bara större",
            "I:Hjälp hjälp hjälp!",
            "I:Solidariteten är stulen!",
            "I:De kopierade min data och jag fick den aldrig tillbaka!"};


        /*
         * String generation
         */
        public static bool HasMoreOf(RandomFactoryReturnType kind)
        {
            ICollection<string> collection = _getCollectionOfType(kind);
            return collection.Count > 0;
        }
        public static string NextOf(RandomFactoryReturnType kind)
        {
            if(!HasMoreOf(kind))
                return null;

            ICollection<string> collection = _getCollectionOfType(kind);
            string res = collection.Last();
            collection.Remove(res);
            return res;
        }


        /*
         * Public random-helpers
         */
        public static bool Bool()
        {
            return rnd.Next(0, 100) > 50;
        }
        public static int Number(int min, int max)
        {
            return rnd.Next(min, max);
        }


        /*
         * privates
         */
        private static ICollection<string> _getCollectionOfType(RandomFactoryReturnType kind)
        {
            switch (kind)
            {
                case RandomFactoryReturnType.BASESTATION:
                    return _basestation_names;
                case RandomFactoryReturnType.INCIDENT:
                    return _incident_descriptions;
                case RandomFactoryReturnType.EMT:
                default:
                    return _emt_names;
            }
        }
    }
}
