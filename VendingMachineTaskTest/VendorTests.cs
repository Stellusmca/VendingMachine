using Xunit;
using VendingMachineTask;

namespace VendingMachineTaskTest
{
    public class VendorTests
    {
        //[Fact]
        //public void VendingMachineContainsWaterAndCrisps()
        //{
        //    string gg = Vendor.machine[0].name;
        //    var expectedValue = "Cola";
        //    // Assert.Equal(Vendor.machine.Length, 2);
        //    Assert.Equal(expectedValue, "Cola");
        //}

        [Fact]
        public void VendingMachineContainsWaterAndCrispsTest()
        {
            // Arrange
            var expectedValue1 = "Water";
            var expectedValue2 = "Crisps";

            // Act
            var actualValue1 = Vendor.machine[0].name;
            var actualValue2 = Vendor.machine[1].name;

            // Assert
            Assert.Equal(expectedValue1, actualValue1);
            Assert.Equal(expectedValue2, actualValue2);
        }
    }
}
