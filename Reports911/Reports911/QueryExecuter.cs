using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;

namespace Reports911
{
    class QueryExecuter : AbstractExecuter
    {
        private ErisDbContext _context;

        public QueryExecuter(ErisDbContext context)
        {
            _context = context;
        }

        public override DataSet AllEmts()
        {
            return _execute(QueryLibrary.GetAllEMTs());
        }

        public override DataSet AllEmtsOnScene()
        {
            return _execute(QueryLibrary.GetAllEMTsOnScene());
        }

        public override DataSet AllEmtsOffScene()
        {
            return _execute(QueryLibrary.GetAllEMTsOffScene());
        }

        public override DataSet AllEmtsForBaseStation(int baseStationId)
        {
            return _execute(QueryLibrary.GetAllEMTsForBaseStation(baseStationId));
        }

        public override DataSet AllActiveIncidents()
        {
            return _execute(QueryLibrary.GetAllActiveIncidents());
        }

        public override DataSet AllBaseStations()
        {
            return _execute(QueryLibrary.GetAllBaseStations());
        }

        public override DataSet NumberOfActiveIncidentsPerBaseStation(int baseStationId)
        {
            return _execute(QueryLibrary.GetNumberOfActiveIncidentsForABaseStation(baseStationId));
        }

        public override DataSet AllBaseStationsAndNumberOfEmtsOffScene()
        {
            return _execute(QueryLibrary.GetAllBaseStationsAndNumberOfEMTsOffScene());
        }

        public override DataSet AllIncidents()
        {
            return _execute(QueryLibrary.GetAllIncidents());
        }

        public override DataSet AllActiveIncidentsForBaseStation(int baseStationId)
        {
            return _execute(QueryLibrary.GetAllActiveIncidentsForBaseStation(baseStationId));
        }

        public override DataSet AllBaseStationsAndNumberOfActiveIncidents()
        {
            return _execute(QueryLibrary.GetAllBaseStationsAndNumberOfActiveIncidents());
        }
    }
}
