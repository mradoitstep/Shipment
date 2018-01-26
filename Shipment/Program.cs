using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipment s = new Shipment();

            Item item = new Item("polozka 1",3, 5.6);
            s.AddItem(item);

            item = new Item("polozka 2", 4, 4.8);
            s.AddItem(item);

            item = new Item("polozka 3", 6, 8.7);
            s.AddItem(item);

            notifikacia n = new notifikacia();
            s.TrekingNumberPridane += n.Notify;
            s.TrekingNumber = "1235874F";
            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
