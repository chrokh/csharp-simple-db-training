using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reports911
{
    class DatabaseSeeder
    {
        private ErisDbContext _context;
        private List<BaseStation> _basestations = new List<BaseStation>();
        private List<Incident> _incidents = new List<Incident>();
        private List<Emt> _emts = new List<Emt>();

        public DatabaseSeeder(ErisDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _createBaseStations();
            _createIncidents();
            _createEmts();
            _connectEmtsToIncidents();
            _saveAll();
        }

        private void _createBaseStations()
        {
            while(RandomFactory.HasMoreOf(RandomFactoryReturnType.BASESTATION))
                _basestations.Add(new BaseStation{
                    Name = RandomFactory.NextOf(RandomFactoryReturnType.BASESTATION)
                });
        }

        private void _createIncidents()
        {
            while(RandomFactory.HasMoreOf(RandomFactoryReturnType.INCIDENT))
                _incidents.Add(new Incident{
                    Active = RandomFactory.Bool(),
                    Description = RandomFactory.NextOf(RandomFactoryReturnType.INCIDENT)
                });
        }

        private void _createEmts()
        {
            while (RandomFactory.HasMoreOf(RandomFactoryReturnType.EMT))
            {
                BaseStation bs = _basestations[RandomFactory.Number(0, _basestations.Count - 1)];
                _emts.Add(new Emt
                {
                    Name = RandomFactory.NextOf(RandomFactoryReturnType.EMT),
                    BaseStation = bs
                });
            }
        }

        private void _connectEmtsToIncidents()
        {
            for (int i = 0; i < _emts.Count / 2; i++)
            {
                Emt e = _emts[i];
                Incident ii = _incidents[RandomFactory.Number(0, _incidents.Count -1)];
                e.Incidents = new List<Incident> { ii };
            }
        }

        private void _saveAll()
        {
            foreach (BaseStation basestation in _basestations)
                _context.basestations.Add(basestation);
            foreach (Incident incident in _incidents)
                _context.incidents.Add(incident);
            foreach (Emt emt in _emts)
                _context.emts.Add(emt);
            _context.SaveChanges();
        }
    }
}
