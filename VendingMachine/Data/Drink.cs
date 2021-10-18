using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Drink : Product
    {
        public Drink(int name, int price) : base(name, price)
        {
            
        }
        
        public override string Examine()
        {
            return $"{Name} is a drink, the price is {Price}.";
        }

        public override string Use()
        {
            return $"The {Name} seems like a nice drink, you decide to quench your thirst";
        }
    }
}