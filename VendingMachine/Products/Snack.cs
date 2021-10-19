using VendingMachine.Model;

namespace VendingMachine.Products
{
    public class Snack : Product
    {
        /// <summary>
        /// Create a new instance of a snack product
        /// </summary>
        /// <param name="name">The name of the snack</param>
        /// <param name="price">The price of the snack</param>
        public Snack(string name, int price) : base(name, price) { }
        
        /// <summary>
        /// Examine this product
        /// </summary>
        /// <returns>Returns a string with the Name, price and info about the product</returns>
        public override string Examine()
        {
            return base.Examine() + $"\n{Name} is a snack, it looks delicious!";
        }

        /// <summary>
        /// Use the product
        /// </summary>
        /// <returns>Returns a string with how you use the product</returns>
        public override string Use()
        {
            return $"You eat the {Name}, it was delicious.";
        }

    }
}