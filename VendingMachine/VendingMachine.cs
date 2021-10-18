using System;
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
        

        public VendingMachine()
        {
            _denominations = new []
            {
                1, 5, 10, 20, 50, 100, 500, 1000
            };

            _products = new Product[]
            {
                new Drink("Kooka-Kohla", 14),
                new Drink("Water", 8),
                new Snack("Ehstrellah Chips", 26),
                new Snack("Lheys Chips", 19),
                new Toy("Roobiks-Kuub", 53),
                new Toy("Action Figure", 35)
            };
        }
        
        public VendingMachine(Product[] products)
        {
            _denominations = new []
            {
                1, 5, 10, 20, 50, 100, 500, 1000
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
            int[] change = new int[0];
            return change;
        }
    }
}