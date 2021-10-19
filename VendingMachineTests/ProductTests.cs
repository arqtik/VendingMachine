using System.Collections;
using System.Collections.Generic;
using VendingMachine.Model;
using VendingMachine.Products;
using Xunit;

namespace VendingMachineTests
{
    public class ProductTests
    {
        /// <summary>
        /// Our data for testing examination of product. Add new products here to test
        /// </summary>
        public static List<object[]> ProductsToTestData => new List<object[]>
        {
            new object[] {new Toy("VeryCoolToyTM", 64)},
            new object[] {new Drink("DeliciousFizzyDrink", 16)},
            new object[] {new Snack("UnhealthySnack", 9)}
        };
        
        [Theory, MemberData(nameof(ProductsToTestData))]
        private void ExamineTest(Product product)
        {
            string examString = product.Examine();
            Assert.Contains(product.Name, examString);
            Assert.Contains(product.Price.ToString(), examString);
        }
    }
}