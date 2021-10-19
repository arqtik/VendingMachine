using System;

namespace VendingMachine.Model
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException(string message) : base(message){}
    }
}