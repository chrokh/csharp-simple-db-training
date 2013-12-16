using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Reports911
{
    enum QueryType
    {
        ALL_EMTS,
        ALL_EMTS_ON_SCENE,
        ALL_EMTS_OFF_SCENE,
        ALL_EMTS_FOR_BASESTATION,
        ALL_ACTIVE_INCIDENTS_FOR_BASESTATION,
        NUMBER_OF_ACTIVE_INCIDENTS_PER_BASESTATION,
        ALL_BASESTATIONS,
        ALL_BASESTATIONS_AND_NUMBER_OF_EMTS_OFF_SCENE,
        ALL_BASESTATIONS_AND_NUMBER_OF_ACTIVE_INCIDENTS,
        ALL_INCIDENTS,
        ALL_ACTIVE_INCIDENTS
    }
    interface IQueryExecuter
    {
        DataSet AllEmts();
        DataSet AllEmtsOnScene();
        DataSet AllEmtsOffScene();
        DataSet AllEmtsForBaseStation(int baseStationId);
        DataSet AllActiveIncidentsForBaseStation(int baseStationId);
        DataSet NumberOfActiveIncidentsPerBaseStation(int baseStationId);
        DataSet AllBaseStations();
        DataSet AllBaseStationsAndNumberOfEmtsOffScene();
        DataSet AllBaseStationsAndNumberOfActiveIncidents();
        DataSet AllIncidents();
        DataSet AllActiveIncidents();
    }
}
