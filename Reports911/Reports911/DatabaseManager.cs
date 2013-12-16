using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reports911
{
    class DatabaseManager
    {
        public static void DropAndReseed(ErisDbContext context)
        {
            context.Database.Delete();
            context.Database.Create();

            Seed(context);
        }

        public static void Seed(ErisDbContext context)
        {
            List<BaseStation> basestations = new List<BaseStation>();
            List<Incident> incidents = new List<Incident>();
            List<Emt> emts = new List<Emt>();

            // basestations
            for (int i = 0; i < RandomFactory.BASE_STATION_NAMES.Count-1; i++)
                basestations.Add(new BaseStation{
                    Name = RandomFactory.EmtName()
                });

            // incidents
            for (int i = 0; i < RandomFactory.INCIDENT_DESCRIPTIONS.Count-1; i++)
                incidents.Add(new Incident{
                    Active = RandomFactory.Bool(),
                    Description = RandomFactory.IncidentDescription()
                });

            // emts
            for (int i = 0; i < RandomFactory.EMT_NAMES.Count-1; i++)
            {
                BaseStation bs = basestations[RandomFactory.Number(0, basestations.Count-1)];
                emts.Add(new Emt{
                    Name = RandomFactory.EmtName(),
                    BaseStation = bs
                });
            }


            // Add emts to incidents
            for (int i = 0; i < emts.Count / 2; i++)
            {
                Emt e = emts[i];
                Incident ii = incidents[RandomFactory.Number(0, incidents.Count -1)];
                e.Incidents = new List<Incident> { ii };
            }


            // Add to db
            foreach (BaseStation basestation in basestations)
                context.basestations.Add(basestation);
            foreach (Incident incident in incidents)
                context.incidents.Add(incident);
            foreach (Emt emt in emts)
                context.emts.Add(emt);

            context.SaveChanges();
        }
    }
}
