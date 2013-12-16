using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reports911
{
    class QueryLibrary
    {

        /*
         * Emts
         */

        public static string GetAllEMTs()
        {
            // Hi student, this is an example :)
            return "SELECT * FROM Emts";
        }

        public static string GetAllEMTsOnScene()
        {
            return "WRITE QUERY HERE";
        }

        public static string GetAllEMTsOffScene()
        {
            return "WRITE QUERY HERE";
        }


        /*
         * Single basestation
         */

        public static string GetAllEMTsForBaseStation(int baseStationId)
        {
            return "WRITE QUERY HERE";
        }

        public static string GetNumberOfActiveIncidentsForABaseStation(int baseStationId)
        {
            return "WRITE QUERY HERE";
        }

        public static string GetAllActiveIncidentsForBaseStation(int baseStationId)
        {
            return "WRITE QUERY HERE";
        }


        /*
         * Basestations
         */

        public static string GetAllBaseStations()
        {
            return "WRITE QUERY HERE";
        }

        public static string GetAllBaseStationsAndNumberOfEMTsOffScene()
        {
            return "WRITE QUERY HERE";
        }

        public static string GetAllBaseStationsAndNumberOfActiveIncidents()
        {
            return "WRITE QUERY HERE";
        }


        /*
         * Incidents
         */

        public static string GetAllIncidents()
        {
            return "WRITE QUERY HERE";
        }

        public static string GetAllActiveIncidents()
        {
            return "WRITE QUERY HERE";
        }
    }
}
