using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Drink : Product
    {
        
        /// <summary>
        /// Create a new instance of a drink product
        /// </summary>
        /// <param name="name">The name of the drink</param>
        /// <param name="price">The price of the drink</param>
        public Drink(string name, int price) : base(name, price) { }
        
        /// <summary>
        /// Examine this product
        /// </summary>
        /// <returns>Returns a string with the Name, price and info about the product</returns>
        public override string Examine()
        {
            return base.Examine() + $"\n{Name} is a drink, a good one to quench your thirst with.";
        }

        /// <summary>
        /// Use the product
        /// </summary>
        /// <returns>Returns a string with how you use the product</returns>
        public override string Use()
        {
            return $"You drink the {Name}, it really hits the spot.";
        }
    }
}