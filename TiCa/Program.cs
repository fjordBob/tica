using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiCa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Comming time: ");
            DateTime timeIn = DateTime.Parse(Console.ReadLine());
            TimeSpan timeWork = new TimeSpan(7, 45, 0);
            DateTime timeLeave = timeIn.Add(timeWork);
            TimeSpan timeWorkMustEnd = new TimeSpan(10, 45, 0);
            DateTime timeMustLeave = timeIn.Add(timeWorkMustEnd);
            Console.WriteLine(timeLeave.ToShortTimeString());
            Console.WriteLine(timeMustLeave.ToShortTimeString());
            Console.ReadKey();
        }
    }
}
