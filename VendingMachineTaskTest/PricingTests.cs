using Xunit;
using System;
using VendingMachineTask;

namespace VendingMachineTaskTest
{
    public class PricingTests
    {
        private const decimal priceOfPepsi = 1.0m;
        PricingSystem virtualSystem = new PricingSystem();
        [Fact]
        public void InsertingCoinsIncreasesBalance()
        {
            Assert.Equal(0, virtualSystem.balance);
            virtualSystem.insertCoins(0.50m, priceOfPepsi);
            Assert.Equal(0.50m, virtualSystem.balance);
        }

        [Fact]
        public void CheckPurchaseReturnsChange()
        {
            Assert.Equal(0.0m, virtualSystem.change);
            virtualSystem.insertCoins(0.50m, priceOfPepsi);
            virtualSystem.checkPurchace(virtualSystem.balance, 0.40m);
            Assert.Equal(0.10m, virtualSystem.change);
        }
    }
}
