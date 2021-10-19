using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class Toy : Product
    {
        /// <summary>
        /// Create a new instance of a toy product
        /// </summary>
        /// <param name="name">The name of the toy</param>
        /// <param name="price">The price of the toy</param>
        public Toy(string name, int price) : base(name, price) { }

        /// <summary>
        /// Examine this product
        /// </summary>
        /// <returns>Returns a string with the Name, price and info about the product</returns>
        public override string Examine()
        {
            return base.Examine() + $"\n{Name} is a toy, it looks pretty fun!";
        }

        /// <summary>
        /// Use the product
        /// </summary>
        /// <returns>Returns a string with how you use the product</returns>
        public override string Use()
        {
            return $"You play with the {Name}";
        }
    }
}