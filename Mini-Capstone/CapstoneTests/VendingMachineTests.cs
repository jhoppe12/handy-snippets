using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;
using System.Collections.Generic;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTests
    {
        VendingMachine vm = new VendingMachine();

        [TestMethod]
        public void AddMoneyTest()
        {
            vm.UserMoney();
            vm.AddMoney(5);      
            Assert.AreEqual(5, vm.UserMoney());
            vm.AddMoney(10);
            Assert.AreEqual(15, vm.UserMoney());
        }
        [TestMethod]
        public void MoneyBackTest()
        {
            
            string result = vm.MoneyBack(5.15M);
            Assert.AreEqual("Your change: 20 quarters, 1 dimes, 1 nickels", result);
            result = vm.MoneyBack(.80M);
            Assert.AreEqual("Your change: 3 quarters, 0 dimes, 1 nickels", result);

        }
        [TestMethod]
        public void MunchyTest()
        {
            string result = vm.Munchy("A3");
            Assert.AreEqual("Crunch Crunch, Yum!", result);

            result = vm.Munchy("D3");
            Assert.AreEqual("Chew Chew, Yum!", result);

        }
        [TestMethod]
        public void ListUpdateTest()
        {
            vm.UserMoney();
            vm.AddMoney(5);
            vm.ReadFile();
            vm.ListUpdate("A3", vm.UserMoney());
            Assert.AreEqual(2.25M, vm.UserMoney());
            VendingMachineItem[] itemArray = vm.List();
            Assert.AreEqual("4", itemArray[2].StartingQuantity);
            
        }

    }
}
