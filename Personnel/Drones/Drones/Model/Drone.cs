namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        private int _charge = 1000;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien

        public string Name { get => _name; set => _name = value; }
        public int Charge { get => _charge;}
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y = MiscHelpers.valueAlea();                  // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            _charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
