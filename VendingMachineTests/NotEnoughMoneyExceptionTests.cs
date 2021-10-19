using VendingMachine.Exceptions;
using Xunit;

namespace VendingMachineTests
{
    public class NotEnoughMoneyExceptionTests
    {
        [Fact]
        private void NotEnoughMoneyExceptionTest()
        {
            int productPrice = 10;
            int availableMoney = 5;

            NotEnoughMoneyException ex = new NotEnoughMoneyException(productPrice, availableMoney);
            
            Assert.Equal($"Not enough money. Product costs {productPrice}kr and {availableMoney}kr is available.", ex.Message);
        }
    }
}