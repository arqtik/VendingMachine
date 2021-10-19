using System;
using System.Collections.Generic;
using VendingMachine.Exceptions;
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
        private void ShowAllTest()
        {
            string allProducts = _vendingMachine.ShowAll();
            
            for (int i = 0; i < _products.Length; i++)
            {
                Assert.Contains(_products[i].Name, allProducts);
                Assert.Contains(_products[i].Price.ToString(), allProducts);
                Assert.Contains(i.ToString(), allProducts);
            }
        }

        [Fact]
        private void InsertMoneyTest()
        {
            _vendingMachine.InsertMoney(10);
            Assert.Equal(10, _vendingMachine.MoneyPool);
            _vendingMachine.InsertMoney(500);
            Assert.Equal(510, _vendingMachine.MoneyPool);
        }
        
        [Fact]
        private void InsertMoneyExceptionTest()
        {
            ArgumentException e = Assert.Throws<ArgumentException>(() => _vendingMachine.InsertMoney(99));
            Assert.Equal("Invalid money denomination input", e.Message);
            Assert.Equal(0, _vendingMachine.MoneyPool);
        }

        [Theory]
        [InlineData(new int[]{20, 1, 50, 5, 1, 10, 500})]
        [InlineData(new int[]{1})]
        [InlineData(new int[]{})]
        private void EndTransactionTest(int[] expectedChange)
        {
            for (int i = 0; i < expectedChange.Length; i++)
            {
                _vendingMachine.InsertMoney(expectedChange[i]);
            }

            int[] actualChange = _vendingMachine.EndTransaction();

            Array.Sort(expectedChange);
            Array.Sort(actualChange);
            
            Assert.Equal(expectedChange, actualChange);
        }

        [Fact]
        private void PurchaseTest()
        {
            _vendingMachine.InsertMoney(50);

            int productIndexToBuy = 2;
            
            Product expectedProduct = _products[productIndexToBuy];

            Assert.Same(expectedProduct, _vendingMachine.Purchase(productIndexToBuy));
        }

        [Fact]
        private void PurchaseOutOfIndexProductExceptionTest()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => _vendingMachine.Purchase(_products.Length));
            Assert.Equal("Product index chosen does not exist" ,ex.Message);
        }

        [Fact]
        private void PurchaseNotEnoughMoneyExceptionTest()
        {
            Assert.Throws<NotEnoughMoneyException>(() => _vendingMachine.Purchase(0));
        }
    }
}