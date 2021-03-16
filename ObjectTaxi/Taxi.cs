using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTaxi
{
    public class Taxi
    {
        // propertis
        public string NamaPengemudi { get; set; }
        public string MembawaPenumpang { get; set; }
        public float NomerPenumpang { get; set; }

        public void InfoDriver()
        {
            Console.WriteLine("Nama Pengemudi: {0}", NamaPengemudi);
            Console.WriteLine("Membawa Penumpang : {0}", MembawaPenumpang);
            Console.WriteLine("Nomer Penumpang : {0}", NomerPenumpang);
            
        }

        public void InfoTaxi()
        {
            Console.WriteLine("Informasi Taxi :");
            Console.WriteLine("{0} Sedang Menjemput Penumpang\n", NamaPengemudi);
            Console.WriteLine("{0} Sedang Mengantar Penumpang\n", NamaPengemudi);
        }
    }

}