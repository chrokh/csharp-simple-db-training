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
            "Ekonomikum",
            "Matematikum",
            "Uppsala Slott",
            "Domkyrkan",
            "Pollacksbacken",
            "Engelska parken",
            "SLU"
        };
        private static List<string> _emt_names = new List<string>(){
            "Räddningspatrullen",
            "Hundpatrullen",
            "Gosskören",
            "Bagarna",
            "Universitetsutryckningen"
        };
        private static List<string> _incident_descriptions = new List<string>(){
            "En hund har fastnat i ett träd!",
            "Hjälp det brinner!",
            "Det är ett bankrån!",
            "Omg någon rånar banken",
            "Banken, banken, banken!",
            "Det brinner i grannhuset"};


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
