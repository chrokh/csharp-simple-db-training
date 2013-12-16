using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Reports911
{
    interface IQueryExecuter
    {
        DataSet AllEmts();
        DataSet AllBaseStations();
        DataSet AllEmtsOnScene();
        DataSet AllEmtsOffScene();
        DataSet AllEmtsForBaseStation(int baseStationId);
        DataSet AllActiveIncidentsForBaseStation(int baseStationId);
        DataSet NumberOfActiveIncidentsPerBaseStation(int baseStationId);
        DataSet AllBaseStationsAndNumberOfEmtsOffScene();
        DataSet AllIncidents();
        DataSet AllActiveIncidents();
        DataSet AllBaseStationsAndNumberOfActiveIncidents();
    }
}
