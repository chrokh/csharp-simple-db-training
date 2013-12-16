using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Reports911
{
    abstract class AbstractExecuter : IQueryExecuter
    {
        public DataSet Execute(QueryType kind)
        {
            return _findQueryMethodWithoutParams(kind)();
        }
        public DataSet Execute(QueryType kind, int data)
        {
            return _findQueryMethodWithParams(kind)(data);
        }

        public abstract DataSet AllEmts();
        public abstract DataSet AllEmtsOnScene();
        public abstract DataSet AllEmtsOffScene();
        public abstract DataSet AllEmtsForBaseStation(int baseStationId);
        public abstract DataSet AllActiveIncidentsForBaseStation(int baseStationId);
        public abstract DataSet NumberOfActiveIncidentsPerBaseStation(int baseStationId);
        public abstract DataSet AllBaseStations();
        public abstract DataSet AllBaseStationsAndNumberOfEmtsOffScene();
        public abstract DataSet AllBaseStationsAndNumberOfActiveIncidents();
        public abstract DataSet AllIncidents();
        public abstract DataSet AllActiveIncidents();

        private Func<DataSet> _findQueryMethodWithoutParams(QueryType kind)
        {
            Dictionary<QueryType, Func<DataSet>> funcs = new Dictionary<QueryType, Func<DataSet>>();
            funcs.Add(QueryType.ALL_EMTS, AllEmts);
            funcs.Add(QueryType.ALL_EMTS_ON_SCENE, AllEmtsOnScene);
            funcs.Add(QueryType.ALL_EMTS_OFF_SCENE, AllEmtsOffScene);
            funcs.Add(QueryType.ALL_BASESTATIONS, AllBaseStations);
            funcs.Add(QueryType.ALL_BASESTATIONS_AND_NUMBER_OF_EMTS_OFF_SCENE, AllBaseStationsAndNumberOfEmtsOffScene);
            funcs.Add(QueryType.ALL_BASESTATIONS_AND_NUMBER_OF_ACTIVE_INCIDENTS, AllBaseStationsAndNumberOfActiveIncidents);
            funcs.Add(QueryType.ALL_INCIDENTS, AllIncidents);
            funcs.Add(QueryType.ALL_ACTIVE_INCIDENTS, AllActiveIncidents);
            return funcs[kind];
        }

        private Func<int, DataSet> _findQueryMethodWithParams(QueryType kind)
        {
            Dictionary<QueryType, Func<int, DataSet>> funcs = new Dictionary<QueryType, Func<int, DataSet>>();
            funcs.Add(QueryType.ALL_EMTS_FOR_BASESTATION, AllEmtsForBaseStation);
            funcs.Add(QueryType.ALL_ACTIVE_INCIDENTS_FOR_BASESTATION, AllActiveIncidentsForBaseStation);
            funcs.Add(QueryType.NUMBER_OF_ACTIVE_INCIDENTS_PER_BASESTATION, NumberOfActiveIncidentsPerBaseStation);
            return funcs[kind];
        }
    }
}
