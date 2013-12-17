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
            // Triplicate each incident
            List<Incident> incidents = _incidents.Concat(_incidents.Concat(_incidents.ToList()).ToList()).ToList();
            incidents = incidents.OrderBy(item => RandomFactory.Number()).ToList();

            // Keep a random set, but at the most as many as original uniques
            while (incidents.Count > RandomFactory.Number(1, _incidents.Count))
                incidents.RemoveAt(RandomFactory.Number(0, incidents.Count - 1));

            // Insert
            while(incidents.Count > 0)
            {
                Incident ii = incidents[0];
                Emt e = _emts[RandomFactory.Number(0, _emts.Count-1)];
                if(e.Incidents == null)
                    e.Incidents = new List<Incident>();
                e.Incidents.Add(ii);
                incidents.Remove(ii);
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
