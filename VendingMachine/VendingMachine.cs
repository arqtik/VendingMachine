using VendingMachine.Model;

namespace VendingMachine
{
    public class VendingMachine: IVending
    {
        public int MoneyPool { get; set; }

        public void Purchase()
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public int EndTransaction()
        {
            throw new System.NotImplementedException();
        }
    }
}