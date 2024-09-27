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
            drone.X = 600;
            drone.Y = 6;
            drone.Name = "Joe";
            fleet.Add(drone);

            // Création des bâtiments
            List<Building> buildings = new List<Building>();

            for (int i = 0; i < 5; i++)
            {
                Factory factory = new Factory(300);
                factory.X = MiscHelpers.CoordAlea();
                factory.Y = MiscHelpers.CoordAlea();

                foreach (Building building in buildings)
                {
                    if (building.X + 20 == factory.X && building.Y + 20 == factory.Y)
                    {
                        factory.X = MiscHelpers.CoordAlea();
                        factory.Y = MiscHelpers.CoordAlea();
                    }

                }

                factory.Show();
                buildings.Add(factory);
            }

            for (int i = 0; i < 5; i++)
            {
                Store store = new Store();
                store.X = MiscHelpers.CoordAlea();
                store.Y = MiscHelpers.CoordAlea();

                foreach (Building building in buildings)
                {
                    if (building.X + 20 == store.X && building.Y + 20 == store.Y)
                    {
                        store.X = MiscHelpers.CoordAlea();
                        store.Y = MiscHelpers.CoordAlea();
                    }

                }

                store.Show();
                buildings.Add(store);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}