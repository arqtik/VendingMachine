using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Snack : Product
    {
        public Snack(int name, int price) : base(name, price)
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