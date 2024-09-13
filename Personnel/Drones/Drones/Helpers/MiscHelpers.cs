using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    class MiscHelpers
    {
        private static Random alea = new Random();

        public static int valueAlea()
        {
            return alea.Next(-2, 3);
        }
    }
}
