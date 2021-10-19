using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Snack : Product
    {
        public Snack(string name, int price) : base(name, price)
        {
            
        }
        
        public override string Examine()
        {
            return base.Examine() + $"\n{Name} is a snack, it looks delicious!";
        }

        public override string Use()
        {
            return $"You eat the {Name}, it was delicious.";
        }

    }
}