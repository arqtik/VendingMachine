using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Drink : Product
    {
        public Drink(string name, int price) : base(name, price)
        {
            
        }
        
        public override string Examine()
        {
            return base.Examine() + $"\n{Name} is a drink, a good one to quench your thirst with.";
        }

        public override string Use()
        {
            return $"You drink the {Name}, it really hits the spot.";
        }
    }
}