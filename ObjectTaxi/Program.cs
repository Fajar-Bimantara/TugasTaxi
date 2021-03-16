using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat object Taxi
            Taxi taxi = new Taxi();

            taxi.NamaPengemudi = "Kamidi";
            taxi.MembawaPenumpang = "Ya";
            taxi.NomerPenumpang = 10;

            // pemanggil method
            taxi.InfoDriver();
            taxi.InfoTaxi();
            
            Console.ReadKey();
        }
    }
}
