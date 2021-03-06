namespace VendingMachine.Model
{
    public abstract class Product
    {
        /// <summary>
        /// The name of the product
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The price of the product
        /// </summary>
        public int Price { get; }

        /// <summary>
        /// Create a new instance of this product
        /// </summary>
        /// <param name="name">The name the product should have</param>
        /// <param name="price">The price of this product</param>
        protected Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Examine the products price and info
        /// </summary>
        /// <returns>Returns products price and info</returns>
        public virtual string Examine()
        {
            return $"{Name}: {Price}kr";
        }
        
        /// <summary>
        /// Use the product
        /// </summary>
        /// <returns>Returns a string as the result of usage</returns>
        public abstract string Use();
    }
}