using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Reports911;
using System.Data.SqlServerCe;
using Fakers;

namespace Reports911
{
    class FakeExecuter : AbstractExecuter
    {
        ErisDbContext _context = new ErisDbContext();

        public override DataSet AllEmts()
        {
            return _execute(FakeQueryLibrary.GetAllEMTs());
        }

        public override DataSet AllBaseStationsAndNumberOfActiveIncidents()
        {
            return _execute(FakeQueryLibrary.GetAllBaseStationsAndNumberOfActiveIncidents());
        }

        public override DataSet AllIncidents()
        {
            return _execute(FakeQueryLibrary.GetAllIncidents());
        }

        public override DataSet AllActiveIncidents()
        {
            return _execute(FakeQueryLibrary.GetAllActiveIncidents());
        }

        public override DataSet AllEmtsOnScene()
        {
            return _execute(FakeQueryLibrary.GetAllEMTsOnScene());
        }

        public override DataSet AllEmtsOffScene()
        {
            return _execute(FakeQueryLibrary.GetAllEMTsOffScene());
        }

        public override DataSet AllEmtsForBaseStation(int baseStationId)
        {
            return _execute(FakeQueryLibrary.GetAllEMTsForBaseStation(baseStationId));
        }

        public override DataSet AllActiveIncidentsForBaseStation(int baseStationId)
        {
            return _execute(FakeQueryLibrary.GetAllActiveIncidentsForBaseStation(baseStationId));
        }

        public override DataSet NumberOfActiveIncidentsPerBaseStation(int baseStationId)
        {
            return _execute(FakeQueryLibrary.GetNumberOfActiveIncidentsForABaseStation(baseStationId));
        }

        public override DataSet AllBaseStations()
        {
            return _execute(FakeQueryLibrary.GetAllBaseStations());
        }

        public override DataSet AllBaseStationsAndNumberOfEmtsOffScene()
        {
            return _execute(FakeQueryLibrary.GetAllBaseStationsAndNumberOfEMTsOffScene());
        }
    }
}
