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
            /*
             * Hi student,
             * this is an example of how you need to 
             * implement the body of these functions.
             * 
             * Basically, all you need to do is express
             * the proper SQL for each of the methods
             * Like the line below... :)
             */
            return "SELECT * FROM Emts";
        }

        public static string GetAllEMTsOnScene()
        {
            return "A_QUERY_THAT_RETURNS_ALL_COLUMNS_OF_ALL_EMTS_THAT_ARE_CURRENTLY_ASSOCIATED_WITH_AN_INCIDENT";
        }

        public static string GetAllEMTsOffScene()
        {
            return "A_QUERY_THAT_RETURNS_ALL_COLUMNS_OF_ALL_EMTS_THAT_ARE_CURRENTLY_NOT_ASSOCIATED_WITH_ANY_INCIDENT";
        }


        /*
         * Single basestation
         */

        public static string GetAllEMTsForBaseStation(int baseStationId)
        {
            return "A_QUERY_THAT_RETURNS_ALL_COLUMNS_FOR_ALL_EMTS_STATIONED_AT_THE_BASESTATION";
        }

        public static string GetNumberOfActiveIncidentsForABaseStation(int baseStationId)
        {
            return "A_QUERY_THAT_RETURNS_ALL_COLUMNS_FOR_EACH_BASESTATION_AND_THE_NUMBER_OF_ACTIVE_INCIDENTS_ASSOCIATED_VIA_EMTS_WITH_THE_BS";
        }

        public static string GetAllActiveIncidentsForBaseStation(int baseStationId)
        {
            return "A_QUERY_THAT_RETURNS_ALL_COLUMNS_FOR_EACH_BASESTATION_AND ALL_COLUMNS_FOR_ALL_ACTIVE_INCIDENTS_ASSOCIATED_VIA_EMTS_WITH_THE_BS";
        }


        /*
         * Basestations
         */

        public static string GetAllBaseStations()
        {
            return "A_QUERY_THAT_RETURNS_ALL_FIELDS_FOR_ALL_BASESTATIONS";
        }

        public static string GetAllBaseStationsAndNumberOfEMTsOffScene()
        {
            return "A_QUERY_THAT_RETURNS_THE_COLUMNS_ID_NAME_AND_THE_NUMBER_OF_AVAILABLE_EMTS_FOR_EACH_BASESTATION";
        }

        public static string GetAllBaseStationsAndNumberOfActiveIncidents()
        {
            return "A_QUERY_THAT_RETURNS_THE_COLUMNS_ID_NAME_AND_THE_NUMBER_OF_ACTIVE_INCIDENTS_FOR_EACH_BASESTATION";
        }


        /*
         * Incidents
         */

        public static string GetAllIncidents()
        {
            return "A_QUERY_THAT_RETURNS_ALL_COLUMNS_FOR_ALL_INCIDENTS";
        }

        public static string GetAllActiveIncidents()
        {
            return "A_QUERY_THAT_RETURNS_ALL_COLUMNS_FOR_ALL_ACTIVE_INCIDENTS";
        }
    }
}
