using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{   //needs tests, similar to pet class in lecture
    //stores information about qty, amt, etc of each item
    public class VendingMachineItem
    {
        public string SlotLocation { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string StartingQuantity { get => startingQuantity; set => startingQuantity = value; }

        public bool isSoldout =false;
        public bool noMoney = false;

        public decimal quarters;
        public decimal dimes;
        public decimal nickels;

        private string startingQuantity = "5";

        public override string ToString()
        {
            return $"{SlotLocation}\t{ProductName}\t\t${Price}\t Quantity: {StartingQuantity}";
        }
    }
}
