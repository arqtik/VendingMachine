using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Toy : Product
    {
        public Toy(string name, int price) : base(name, price)
        {
            
        }

        public override string Examine()
        {
            return $"{Name} is a toy, the price is {Price}.";
        }

        public override string Use()
        {
            return $"The {Name} looks like a fun toy, you decide to play with it.";
        }
    }
}