namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            // Création des bâtiments
            List<Building> buildings = new List<Building>();
            Factory factory = new Factory(300);
            factory.X = 700;
            factory.Y = 400;
            buildings.Add(factory);

            Store store = new Store();
            store.X = 700;
            store.Y = 400;
            buildings.Add(store);

            for (int i = 0; i < 4; i++)
            {
                factory.X = MiscHelpers.CoordAlea();
                factory.Y = MiscHelpers.CoordAlea();

                foreach (Building building in buildings)
                {
                    if (factory.X == factory.Y)
                    {
                        factory.X = MiscHelpers.CoordAlea();
                        factory.Y = MiscHelpers.CoordAlea();
                    }

                }

                buildings.Add(factory);
            }

            store.Show();
            factory.Show();

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}