using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Exceptions;
using VendingMachine.Model;

namespace VendingMachine
{
    public class VendingMachine: IVending
    {
        private readonly int[] _denominations;
        private Product[] _products;
        
        /// <summary>
        /// Current amount of inserted money that is left
        /// </summary>
        public int MoneyPool { get; private set; }
        
        /// <summary>
        /// Create a new Vending Machine instance
        /// </summary>
        /// <param name="products">Array of products available in the vending machine</param>
        public VendingMachine(Product[] products)
        {
            _denominations = new []
            {
                1000, 500, 100, 50, 20, 10, 5, 1
            };

            _products = products;
        }

        /// <summary>
        /// Purchase a product from the vending machine using the money inserted
        /// </summary>
        /// <param name="productIndex">The index of the product you want to purchase</param>
        /// <returns>Returns reference to the product purchased</returns>
        /// <exception cref="ArgumentException">If the product index does not exist</exception>
        /// <exception cref="NotEnoughMoneyException">If not enough money in the money pool to purchase product</exception>
        public Product Purchase(int productIndex)
        {
            if (productIndex > 0 && productIndex < _products.Length)
            {
                Product product = _products[productIndex];

                if (product.Price <= MoneyPool)
                {
                    MoneyPool -= product.Price;
                    return product;
                }
                else
                {
                    throw new NotEnoughMoneyException(product.Price, MoneyPool);
                }
            }
            else
            {
                throw new ArgumentException("Product index chosen does not exist");
            }
        }
        
        /// <summary>
        /// Shows all of the products available in the vending machine with their index and price
        /// </summary>
        /// <returns>Returns a string with all the products, their indexes and price. Could contain multiple lines</returns>
        public string ShowAll()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _products.Length; i++)
            {
                sb.Append($"[{i}] {_products[i].Name}\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Insert money into the vending machine
        /// </summary>
        /// <param name="money">The money unit you want to insert. Should be of a valid denomination</param>
        /// <exception cref="ArgumentException">Throws exception if invalid denomination input</exception>
        public void InsertMoney(int money)
        {
            if (_denominations.Contains(money))
            {
                MoneyPool += money;
            }
            else
            {
                throw new ArgumentException("Invalid money denomination input");
            }
        }

        /// <summary>
        /// Ends the current transaction
        /// </summary>
        /// <returns>Returns array of all denominations that should be returned</returns>
        public int[] EndTransaction()
        {
            List<int> change = new List<int>();

            int moneyToGiveBack = MoneyPool;
            MoneyPool = 0;
            
            for (int i = 0; i < _denominations.Length; i++)
            {
                while (moneyToGiveBack >= _denominations[i])
                {
                    change.Add(_denominations[i]);
                    moneyToGiveBack -= _denominations[i];
                }
            }

            return change.ToArray();
        }
    }
}