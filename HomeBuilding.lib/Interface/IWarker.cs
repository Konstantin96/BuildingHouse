using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilding.lib.Interface
{
    public enum Special
    {
        kam,plot,other
    }
    interface IWarker
    {
        bool IsTeam { get; set; }
        int Age { get; set; }
        string FIO { get; set; }
        Special Special { get; set; }
        double SalaryInHour { get; set; }
        //double SpeedWork { get; set; }
    }
}
