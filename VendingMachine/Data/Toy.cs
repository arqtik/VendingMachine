using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Toy : Product
    {
        public Toy(int name, int price) : base(name, price)
        {
            
        }

        public override string Examine()
        {
            throw new System.NotImplementedException();
        }

        public override string Use()
        {
            throw new System.NotImplementedException();
        }
    }
}