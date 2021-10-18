namespace VendingMachine.Model
{
    public abstract class Product
    {
        /// <summary>
        /// The name of the product
        /// </summary>
        public int Name { get; }

        /// <summary>
        /// The price of the product
        /// </summary>
        public int Price { get; }

        protected Product(int name, int price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Examine the products price and info
        /// </summary>
        /// <returns>Returns products price and info</returns>
        public abstract string Examine();
        
        /// <summary>
        /// Use the product
        /// </summary>
        /// <returns>Returns a string as the result of usage</returns>
        public abstract string Use();
    }
}