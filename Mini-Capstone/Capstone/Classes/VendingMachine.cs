using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace Capstone.Classes
{  //load all data and work on the data here - no console write/read lines, needs test
    public class VendingMachine
    { //only read the file once, keep track of everything here, 
      //csv is read only file, do not write back; write audit trail & sales report


        private List<VendingMachineItem> items = new List<VendingMachineItem>();

        public bool soldout = false;
        public bool noMoney = false;
        decimal userMoney = 0;
        decimal totalSales = 0;

        private string filePath = @"C:\VendingMachine";
        private string fileName = "vendingmachine.csv";
        private string logName = "Log.txt";
        //private string saleLog = "SalesReport.txt";
        public VendingMachineItem currItem = new VendingMachineItem();

        public bool ReadFile()
        {
            bool result = true;
            try
            {
                string path = Path.Combine(filePath, fileName);
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string nextItem = sr.ReadLine();
                        string[] splitItem = nextItem.Split("|");

                        VendingMachineItem vendingMachineItem = new VendingMachineItem();

                        vendingMachineItem.SlotLocation = splitItem[0];
                        vendingMachineItem.ProductName = splitItem[1];
                        vendingMachineItem.Price = Decimal.Parse(splitItem[2]);
                        vendingMachineItem.StartingQuantity = "5";

                        items.Add(vendingMachineItem);

                    }

                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public VendingMachineItem[] List()
        {
            return items.ToArray();
        }

        public void ListUpdate(string slot, decimal money)
        {
            foreach (VendingMachineItem item in items)
            {
                if (item.SlotLocation == slot)
                {
                    noMoney = false;
                    currItem = item;
                    if (item.StartingQuantity == "SOLD OUT")
                    {
                        item.isSoldout = true;
                    }
                    if (money > item.Price && !item.isSoldout)
                    {
                        int quantity = Int32.Parse(item.StartingQuantity);
                        quantity -= 1;

                        if (quantity == 0)
                        {
                            soldout = true;
                            item.StartingQuantity = "SOLD OUT";
                        }
                        else
                        {
                            item.StartingQuantity = quantity.ToString();
                        }
                        money -= item.Price;
                        totalSales += item.Price;
                        userMoney = money;
                        Munchy(item.SlotLocation);
                        WriteLog($"{DateTime.Now}  {item.ProductName}  {item.SlotLocation}  ${(userMoney + item.Price)} ${userMoney}");
                        
                    }
                    else if (money > item.Price && soldout)
                    {
                        
                    }
                    else 
                    {
                        noMoney = true;                      
                    }
                }
                else
                {

                }
            }
        }

        public void AddMoney( int n)
        {
            userMoney += n;
        }

        public decimal UserMoney()
        {
            return userMoney;
        }

        public string MoneyBack(decimal beforeChange)
        {
            string moneyBack = "";
           
            decimal remainder1 = beforeChange % .25M;
            decimal remainder2 = remainder1 % .10M;
            decimal remainder3 = remainder2 % .05M;
            decimal quarters = (beforeChange - remainder1) / .25M;
            decimal dimes = (remainder1 - remainder2) / .10M;
            decimal nickels = remainder2 / .05M;
            WriteLog($"{DateTime.Now}  GIVE CHANGE:  ${beforeChange}  ${remainder3}");
            moneyBack = $"Your change: {quarters} quarters, {dimes} dimes, {nickels} nickels";
            userMoney = 0;
            return moneyBack;              
        }

        public void WriteLog(string entry)
        {
            string path = Path.Combine(filePath, logName);
            StreamWriter sw = new StreamWriter(path, true);
            using (sw)
            {
                sw.WriteLine(entry);
            }
        }

        public string Munchy(string item)
        {
            string result = "";
            if (item.Contains("A"))
            {
                result = "Crunch Crunch, Yum!";
            }
            if (item.Contains("B"))
            {
                result = "Munch Munch, Yum!";
            }
            if (item.Contains("C"))
            {
                result = "Glug Glug, Yum!";
            }
            if (item.Contains("D"))
            {
                result = "Chew Chew, Yum!";
            }
            return result;
        }

        public void WriteSales()
        {   
            try
            {
                DateTime time = DateTime.Now;             
                string format = "MMM ddd d yyyy HHmm";                  
                string date = time.ToString(format);
                string name = "SalesReport_"+date +".txt";
                string fullpath = Path.Combine(filePath, name);
                using (StreamWriter sw = new StreamWriter(fullpath, true))
                {
                    foreach (VendingMachineItem item in items)
                    {
                        int quantity = 5 - Int32.Parse(item.StartingQuantity);
                        sw.WriteLine($"{item.ProductName} | {quantity}");
                    }
                    sw.WriteLine();
                    sw.WriteLine($"** TOTAL SALES **  ${totalSales}");
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}


