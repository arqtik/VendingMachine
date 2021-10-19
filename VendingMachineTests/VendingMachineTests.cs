using System;
using System.Collections.Generic;
using VendingMachine.Model;
using VendingMachine.Products;
using Xunit;

namespace VendingMachineTests
{
    public class VendingMachineTests
    {
        private Product[] _products;
        private VendingMachine.VendingMachine _vendingMachine;

        public VendingMachineTests()
        {
            _products = new Product[]
            {
                new Drink("Kooka-Kohla", 14),
                new Drink("Water", 8),
                new Snack("Ehstrellah Chips", 26),
                new Snack("Lheys Chips", 19),
                new Toy("Roobiks-Kuub", 53),
                new Toy("Action Figure", 35)
            };

            _vendingMachine = new VendingMachine.VendingMachine(_products);

        }
        
        [Fact]
        public void VendingMachineTest()
        {
            
        }

        
    }
}