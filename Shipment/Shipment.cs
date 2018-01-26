using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    class Shipment
    {

        ArrayList DbPolozky = new ArrayList();
        private string trakingNumber;
        public delegate void OnShipmentMade(string Message);
        public event OnShipmentMade TrekingNumberPridane;
        public void AddItem(Item item)
        {

            DbPolozky.Add(item);
               
        }
        public string TrekingNumber
        {
            get
            {
                return trakingNumber;
            }
            set
            {
                trakingNumber = value;
                TrekingNumberPridane?.Invoke(GetInfo());
            }
           
        }
        public string GetInfo()
        {
            string message = "";
            foreach(Item balik in DbPolozky)
            {
                message += balik.Nazov + Environment.NewLine;
                message += balik.CenaZakus + Environment.NewLine;
                message += balik.PocetKusov + Environment.NewLine;

            }
            return message;
        }

    }
}
