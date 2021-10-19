using System;

namespace VendingMachine.Exceptions
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException(int productPrice, int moneyAvailable) 
            : base($"Not enough money. Product costs {productPrice}kr and {moneyAvailable}kr is available.") { }
    }
}