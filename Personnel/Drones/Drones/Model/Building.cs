using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        private int _x;
        private int _y;

        private int _dimension_largeur = 10;
        private int _dimension_profondeur = 10;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int Dimension_largeur { get => _dimension_largeur; set => _dimension_largeur = value; }
        public int Dimension_profondeur { get => _dimension_profondeur; set => _dimension_profondeur = value; }
    }
}
