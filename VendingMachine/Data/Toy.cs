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
            return base.Examine() + $"\n{Name} is a toy, it looks pretty fun!";
        }

        public override string Use()
        {
            return $"You play with the {Name}";
        }
    }
}