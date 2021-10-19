using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Data;
using VendingMachine.Model;

namespace VendingMachine
{
    public class VendingMachine: IVending
    {
        private readonly int[] _denominations;
        private Product[] _products;
        
        public int MoneyPool { get; private set; }
        
        
        public VendingMachine(Product[] products)
        {
            _denominations = new []
            {
                1000, 500, 100, 50, 20, 10, 5, 1
            };

            _products = products;
        }

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
                    throw new ArgumentException("There is not enough money in the pool to buy this product");
                }
            }
            else
            {
                throw new ArgumentException("Product chosen does not exist");
            }
        }

        public string ShowAll()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _products.Length; i++)
            {
                sb.Append($"[{i}] {_products[i].Name}\n");
            }

            return sb.ToString();
        }

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