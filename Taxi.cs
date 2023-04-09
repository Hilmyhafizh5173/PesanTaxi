using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesanTaxi
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo() 
        {
            string duty = "";
            if (OnDuty == true) 
            {
                duty = "yes";
            }else
            {
                duty="no";
            }

            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", duty);
            Console.WriteLine("Number of passenger: {0}", NumPassenger);
        }
        public void PickUpPassenger() 
        {
            Console.WriteLine("\nJono sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger() 
        {
            Console.WriteLine("Jono selesai menjemput penumpang\n", DriverName);
        }

    }
}
