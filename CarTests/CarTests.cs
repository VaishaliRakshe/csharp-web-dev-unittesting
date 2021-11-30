using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    
    public class CarTests
    {
        Car test_car;
        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Honda", "Civic", 22, 39.64);
        }
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            Car test_car = new Car("Honda", "Civic", 22, 39.64);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankAfterDrivingInRange()
        {
            test_car.Drive(50);
            System.Console.WriteLine(test_car.GasTankLevel);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterDrivingPastRange()
        {
            test_car.Drive(875);
            Assert.AreEqual(0, test_car.GasTankLevel, .001);
        }
        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        
            {
            test_car.Drive(5);
            Assert.Fail("Shouldn't get here,car cannot have more gas intank than the size of the tank");
        }
    }
}
