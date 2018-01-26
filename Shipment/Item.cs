using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    class Item
    {
        public string Nazov;
        public int PocetKusov;
        public double CenaZakus = 1;
        
        public Item (string Nazov,int PocetKusov, double CenaZakus)
        {
            this.Nazov = Nazov;
            this.PocetKusov = PocetKusov;
            this.CenaZakus = CenaZakus;

        }
    }
}
