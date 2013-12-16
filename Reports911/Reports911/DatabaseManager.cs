using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reports911
{
    class DatabaseManager
    {
        public static void Seed(ErisDbContext context)
        {
            List<BaseStation> basestations = new List<BaseStation>();
            List<Incident> incidents = new List<Incident>();
            List<Emt> emts = new List<Emt>();


            // basestations
            while(RandomFactory.HasMoreOf(RandomFactoryReturnType.BASESTATION))
                basestations.Add(new BaseStation{
                    Name = RandomFactory.NextOf(RandomFactoryReturnType.BASESTATION)
                });


            // incidents
            while(RandomFactory.HasMoreOf(RandomFactoryReturnType.INCIDENT))
                incidents.Add(new Incident{
                    Active = RandomFactory.Bool(),
                    Description = RandomFactory.NextOf(RandomFactoryReturnType.INCIDENT)
                });


            // emts
            while (RandomFactory.HasMoreOf(RandomFactoryReturnType.EMT))
            {
                BaseStation bs = basestations[RandomFactory.Number(0, basestations.Count - 1)];
                emts.Add(new Emt
                {
                    Name = RandomFactory.NextOf(RandomFactoryReturnType.EMT),
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
