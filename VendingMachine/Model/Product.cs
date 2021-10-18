namespace VendingMachine.Model
{
    public abstract class Product
    {
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