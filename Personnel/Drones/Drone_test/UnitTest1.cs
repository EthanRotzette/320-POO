using Drones;

namespace Drone_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_charge_batterie_is_1000()
        {
            Drone drone = new Drone();

            Assert.AreEqual(1000, drone.Charge, "Un nouveau drone n'a pas une charge de 1000 au départ");
        }

        [TestMethod]
        public void Test_charge_batterie_down()
        {
            Drone drone = new Drone();
            int result;

            result = drone.ChargeActu;

            Assert.AreNotEqual(1000, result, "La batterie ne descend pas a chaque update");
        }

        [TestMethod]
        public void Test_charge_is_lower_than_20_pourcent_lowBatterie_is_true()
        {
            Drone drone = new Drone();

            Assert.IsFalse(drone.LowBattery, "LowBattery ne vaut pas true lorsque la charge est a 20%");
            drone.Charge = 10;
            Assert.IsTrue(drone.LowBattery, "LowBattery ne vaut pas true lorsque la charge est a 20%");

        }
        [TestMethod]
        public void Test_Methode_Update_has_no_effect_when_batterie_egual_0()
        {

        }
    }
}