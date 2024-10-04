using Drones;

namespace Drone_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_charge_batterie_is_1000()
        {
            Drone drone = new Drone(500, 500);

            Assert.AreEqual(1000, drone.Charge, "Un nouveau Drone n'a pas une charge de 1000 au départ");
        }

        [TestMethod]
        public void Test_charge_batterie_down()
        {
            Drone drone = new Drone(500, 500);
            int result;

            result = drone.ChargeActu;

            Assert.AreNotEqual(1000, result, "La batterie ne descend pas a chaque update");
        }

        [TestMethod]
        public void Test_charge_is_lower_than_20_pourcent_lowBatterie_is_true()
        {
            Drone drone = new Drone(500, 500);

            Assert.IsFalse(drone.LowBattery, "LowBattery ne vaut pas true lorsque la charge est a 20%");
            drone.Charge = 10;
            Assert.IsTrue(drone.LowBattery, "LowBattery ne vaut pas true lorsque la charge est a 20%");

        }
        [TestMethod]
        public void Test_Methode_Update_has_no_effect_when_batterie_egual_0()
        {

        }

        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }
        [TestMethod]
        public void Test_that_valid_the_Dispatch_methods()
        {
            // Arrange
            List<Box> box = new List<Box>();

            Dispatch dispatch = new Dispatch();

            // Act
            for(int i = 0; i < 50; i++)
            {
                Box box2 = new Box();
                box.Add(box2);
            }
            
            foreach (Box boxe in box)
            {
                dispatch.AddBox(boxe);
            }
            
            for(int i = 49; i > 47; i--)
            {
                dispatch.RemoveBox(box[i]);
                box.RemoveAt(i);
            }

            // Assert
            for (int j = 0; j < 48; j++)
            {
                Assert.AreEqual(box[j], dispatch.boxes[j], "Les listes ne correspondent pas");
            }
        }
    }
}