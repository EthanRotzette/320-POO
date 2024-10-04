using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Dispatch : IDispatchable
    {
        List<Box> boxes = new List<Box>();

        public bool PassBox(Box box)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBox(Box box)
        {
            throw new NotImplementedException();
        }
    }
}
