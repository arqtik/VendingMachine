using VendingMachine.Model;

namespace VendingMachine
{
    public interface IVending
    {
        /// <summary>
        /// Purchase a product
        /// </summary>
        public void Purchase(Product product);
        
        /// <summary>
        /// Shows all products available
        /// </summary>
        public string ShowAll();
        
        /// <summary>
        /// Add money to the money pool
        /// </summary>
        public void InsertMoney(int money);
        
        /// <summary>
        /// Returns money left from the transaction in appropriate amount of change.
        /// </summary>
        public int EndTransaction();
    }
}