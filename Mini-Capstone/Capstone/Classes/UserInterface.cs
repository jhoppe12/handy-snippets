using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class UserInterface
    { //prompting the user and callimg method here - this is not testable
        private VendingMachine vendingMachine = new VendingMachine();

        public bool itemSoldOut = false;
        public bool noMoney = false;

        public void RunInterface()
        {   vendingMachine.ReadFile();
            bool done = false;
            while (!done)
            {
                //Console.WriteLine("This is the UserInterface");
                //Console.ReadLine();
                try
                { //main menu
                    
                    Console.WriteLine("(1) Display Vending Machine Items");
                    Console.WriteLine("(2) Purchase");
                    Console.WriteLine("(3) End");
                    int userInput = Int32.Parse(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            ShowItems();
                            break;
                        case 2:
                            ItemSelection();
                            break;
                        case 3:
                            done = true;
                            break;
                        case 9:
                            vendingMachine.WriteSales();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    done = true;
                }
            }
        }
        private void ShowItems()
        {
            VendingMachineItem[] currentItems = vendingMachine.List();

            foreach (VendingMachineItem item in currentItems)
            {
                Console.WriteLine(item.ToString());
            }

        }
        public void ItemSelection()
        { 
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            int userInput = Int32.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    FeedMoney();

                    break;
                case 2:                 
                    SelectProduct();
                    break;
                case 3:
                   Console.WriteLine(vendingMachine.MoneyBack(vendingMachine.UserMoney()));
                    break;
            }
        }
        private void FeedMoney()
        { //if 1 is chosen from submenu
            bool doneWithMoney = false;

            try
            {
                
                while (!doneWithMoney)
                {
                    Console.WriteLine("Please enter $(1), $(2), $(5), or $(10) bills.");
                    int userInput = Int32.Parse(Console.ReadLine());
                    if (userInput == 1 || userInput == 2 || userInput == 5 || userInput == 10)
                    {
                        vendingMachine.AddMoney(userInput);
                        Console.WriteLine($"You currently have ${vendingMachine.UserMoney()}");
                        vendingMachine.WriteLog($"{DateTime.Now} FEED MONEY: ${userInput} ${vendingMachine.UserMoney()}");
                        Console.WriteLine("Would you like to add more money?(y)(n)");
                        string moreUserInput = Console.ReadLine();
                        if (moreUserInput == "n")
                        {
                            doneWithMoney = true;
                            ItemSelection();
                        }
                        else if (moreUserInput == "y")
                        {

                        }
                        else
                        {
                            doneWithMoney = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid amount.");
                        
                    }
                    

                }
            }
            catch(Exception ex)
            {
                doneWithMoney = true;
            }
        }
        private void SelectProduct()
        {
            Console.WriteLine("Please enter slot location:");
            string slotLocation = Console.ReadLine();
            vendingMachine.ListUpdate(slotLocation, vendingMachine.UserMoney());
            if (vendingMachine.currItem.isSoldout)
            {
                Console.WriteLine("Sorry this item is sold out :(");
            }
            else if (vendingMachine.noMoney)
            {
                Console.WriteLine("You do not have enough money.");
            }
            else if (!vendingMachine.noMoney && !itemSoldOut)
            {
                Console.WriteLine(vendingMachine.Munchy(slotLocation));
            }


            ItemSelection();
        }       
    }
}
