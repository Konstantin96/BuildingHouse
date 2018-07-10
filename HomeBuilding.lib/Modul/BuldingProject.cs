using HomeBuilding.lib.Interface;
using HomeBuilding.lib.Modul.HomeBuilding.lib.Modul.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
using HomeBuilding.lib.Modul.HomeBuilding.lib.Modul.Team;

namespace HomeBuilding.lib.Modul
{
    class BuldingProject
    {
        public List<IPart> ListWork = new List<IPart>();
        public List<IWarker> Workers = new List<IWarker>();
        Random rnd = new Random();

        public void CreateWorks()
        {
            int c = rnd.Next(1, 3);
            for (int i = 0; i < c; i++)
            {
                Basement basement = new Basement();
                basement.Company = "Asar";
                basement.Count = 1;
                basement.Material = "Beton";
                basement.Price = rnd.Next();
                ListWork.Add(basement);
            }
            for (int i = 0; i < c * 4; i++)
            {
                Walls wall = new Walls();
                wall.Company = "Asar";
                wall.Count = 1;
                wall.Material = "Kirpich";
                wall.SizeX = 10;
                wall.SizeY = 12;
                wall.Price = wall.SizeX * wall.SizeY * 15;
                wall.Color = ConsoleColor.DarkYellow;
                ListWork.Add(wall);
            }
            for (int i = 0; i < rnd.Next(2, c * 6); i++)
            {
                Window window = new Window();
                window.Company = "WindowBuild";
                window.Count = 1;
                window.Material = "Plastik";
                window.Price = rnd.Next(10000, 50000);
                window.SizeX = 1000;
                window.SizeY = 800;
                ListWork.Add(window);
            }
            for (int i = 0; i < c * 4; i++)
            {
                Door door = new Door();
                door.Company = "DoorPrint";
                door.Material = "Wood";
                door.Count = 1;
                door.SizeX = 1800;
                door.SizeY = 800;
                door.Price = 50000;
                ListWork.Add(door);
            }
            ListWork.Add(new Roof() { Count = 1, Price = rnd.Next() });
        }

        public void CreateTeam()
        {
            int count = rnd.Next(5, 11);
            for (int i = 0; i < count; i++)
            {
                Worker worker = new Worker();
                worker.FIO = GetUserName();
                worker.Age = rnd.Next(22, 51);
                worker.Special = (Special)rnd.Next(3);
                worker.SalaryInHour = rnd.Next(800, 3500);
                Workers.Add(worker);
            }
            TeamLeader Leader = new TeamLeader();
            Leader.FIO = GetUserName();
            Leader.Age = rnd.Next(30, 51);
            Leader.SalaryInHour = rnd.Next(4000, 10000);
            Leader.Brigada = Workers;

            Workers.Add(Leader);
        }

        private string GetUserName()
        {
            Generator genName = new Generator();
            return genName.GenerateDefault((Gender)rnd.Next(2))
                 .Replace("<center><b><font size=7>", "")
                 .Replace("</font></b></center>", "")
                 .Replace("\n", "")
                 .Substring(1);
        }
        public void StartWork()
        {
            TeamLeader leader =(TeamLeader) Workers.FirstOrDefault(f => f.IsTeam == true);

            for (int i = 0; i < ListWork.Count; i++)
            {
                Worker w= leader[leader.GetWorkerID()];
                IPart p = GetWork();
                if (p != null)
                {
                    ListWork.IndexOf(p);
                }
            }
        }
        private IPart GetWork()
        {
            ListWork = ListWork.OrderBy(o => o.Sort).ToList();

            IPart p = (IPart)ListWork.
                Where(w => w.DateStart == null).
                Take(1);
            return p;
        }
    }


}
