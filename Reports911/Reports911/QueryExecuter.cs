using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;

namespace Reports911
{
    class QueryExecuter : IQueryExecuter
    {
        public DataSet AllEmts()
        {
            return _execute(QueryLibrary.GetAllEMTs());
        }

        public DataSet AllEmtsOnScene()
        {
            return _execute(QueryLibrary.GetAllEMTsOnScene());
        }

        public DataSet AllEmtsOffScene()
        {
            return _execute(QueryLibrary.GetAllEMTsOffScene());
        }

        public DataSet AllEmtsForBaseStation(int baseStationId)
        {
            return _execute(QueryLibrary.GetAllEMTsForBaseStation(baseStationId));
        }

        public DataSet AllActiveIncidents()
        {
            return _execute(QueryLibrary.GetAllActiveIncidents());
        }

        public DataSet AllBaseStations()
        {
            return _execute(QueryLibrary.GetAllBaseStations());
        }

        public DataSet NumberOfActiveIncidentsPerBaseStation(int baseStationId)
        {
            return _execute(QueryLibrary.GetNumberOfActiveIncidentsForABaseStation(baseStationId));
        }

        public DataSet AllBaseStationsAndNumberOfEmtsOffScene()
        {
            return _execute(QueryLibrary.GetAllBaseStationsAndNumberOfEMTsOffScene());
        }

        public DataSet AllIncidents()
        {
            return _execute(QueryLibrary.GetAllIncidents());
        }

        public DataSet AllActiveIncidentsForBaseStation(int baseStationId)
        {
            return _execute(QueryLibrary.GetAllActiveIncidentsForBaseStation(baseStationId));
        }

        public DataSet AllBaseStationsAndNumberOfActiveIncidents()
        {
            return _execute(QueryLibrary.GetAllBaseStationsAndNumberOfActiveIncidents());
        }

        private static DataSet _execute(string sql)
        {
            using (SqlCeConnection connection = new SqlCeConnection(@"Data Source = eris911.sdf"))
            {
                using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(sql, connection))
                {
                    DataSet resultSet = new DataSet();
                    adapter.Fill(resultSet, "PRIMARY");
                    return resultSet;
                }
            }
        }
    }
}
