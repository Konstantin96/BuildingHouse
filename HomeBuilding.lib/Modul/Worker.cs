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
        class Worker : IWarker
        {
            public bool IsTeam { get; set; } = true;
            public int Age { get; set; }

            public string FIO
            { get; set; }

            public double SalaryInHour
            { get; set; }

            public Special Special
            { get; set; }
        }
    }
}


