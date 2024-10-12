using System;
using Xunit;
using VendingMachineTask;

namespace VendingMachineTaskTest
{
    public class ItemTest
    {
        [Fact]
        public void TestWorkingConstructor()
        {
            Item product = new Item("pepsi", 0.50m);
            Assert.Equal(0.50m, product.price);
            Assert.Equal("pepsi", product.name);
        }
    }
}
