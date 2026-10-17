using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AssetsApp.Data
{
    public class Asset
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        public DateOnly DateAcquired { get; set; }
        public bool InUse {  get; set; }
        public double PurchasePrice { get; set; }

        public Asset()
        {
            Name = string.Empty;
            Location = string.Empty;
        }

        
        public Asset(int id,string name, string location, DateOnly dateAcquired, bool inUse, double purchasePrice)
        {
            ID = id;
            Name = name;
            Location = location;
            DateAcquired = dateAcquired;
            InUse = inUse;
            PurchasePrice = purchasePrice;
        }
        
        public override string ToString() {
            var str = ID + ": " + Name + " @ " + Location +
               " £" + PurchasePrice +
               " (acquired " + DateAcquired.ToShortDateString() + ")";

            if (InUse)
            {
                str = str + " **";
            }
            return str;
        }
    } // END CLASS
}
