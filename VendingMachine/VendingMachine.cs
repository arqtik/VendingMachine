using System;
using System.Linq;
using VendingMachine.Model;

namespace VendingMachine
{
    public class VendingMachine: IVending
    {
        private readonly int[] _denominations;

        public int MoneyPool { get; private set; }

        public VendingMachine()
        {
            _denominations = new []
            {
                1, 5, 10, 20, 50, 100, 500, 1000
            };
        }

        public void Purchase(Product product)
        {
            throw new System.NotImplementedException();
        }

        public string ShowAll()
        {
            throw new System.NotImplementedException();
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