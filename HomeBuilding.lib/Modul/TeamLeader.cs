using HomeBuilding.lib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilding.lib.Modul
{
    namespace HomeBuilding.lib.Modul.Team
    {
        class TeamLeader : IWarker
        {
            public int Age { get; set; }
            public string FIO { get; set; }
            public double SalaryInHour { get; set; }
            public Special Special { get; set; }

            public bool IsTeam { get; set; } = false;

            public List<IWarker> Brigada = new List<IWarker>();
            Random rnd = new Random();
            //public Worker GetWorker()
            //{
            //    return (Worker)Brigada.ElementAt(rnd.Next(0, Brigada.Count - 1));
            //}
            
            public int GetWorkerID()
            {
                return rnd.Next(0, Brigada.Count - 1);
            }
            public Worker this [int WorkerID]
            {
                get { return (Worker)Brigada.ElementAt(WorkerID); }
            }
        }
    }
}
