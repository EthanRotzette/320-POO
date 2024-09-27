
using System.Drawing.Text;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        private int _charge = 1000;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private int _chargeActu;
        private bool _lowBattery;
        private EvacuationState _evacuationState;
        private Rectangle _NoFlyZone;

        public string Name { get => _name; set => _name = value; }
        public int Charge { get => _charge; set => _charge = value; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int ChargeActu { get => _chargeActu; set => _chargeActu = value; }
        public bool LowBattery { get => _lowBattery; set => _lowBattery = value; }

        public Drone(int y, int x)
        {
            X = x;
            Y = y;
            _evacuationState = EvacuationState.Free;
        }
        public bool Evacuate(Rectangle zone)
        {
            _NoFlyZone = zone;
            Rectangle drone = new Rectangle(X - 4, Y - 2, 8, 8);

            if (!_NoFlyZone.IntersectsWith(drone))
            {
                _evacuationState = EvacuationState.Evacuated;
                return true;
            }
            else
            {
                _evacuationState = EvacuationState.Evacuating;
                return false;
            }
        }

        public void FreeFlight()
        {
            _evacuationState = EvacuationState.Free;
            _NoFlyZone = Rectangle.Empty;
        }

        public EvacuationState GetEvacuationState()
        {
            return _evacuationState;
        }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            X += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            Y = MiscHelpers.valueAlea();                  // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            _charge--;                                  // Il a dépensé de l'énergie
            ChargeActu = _charge;
            
        }

    }
}
