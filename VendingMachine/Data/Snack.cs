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
            return $"{Name} is a snack, the price is {Price}.";
        }

        public override string Use()
        {
            return $"The {Name} looks delicious, you decide to eat it.";
        }

    }
}