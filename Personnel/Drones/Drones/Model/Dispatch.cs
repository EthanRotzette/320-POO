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

        public void PassBox(Box box)
        {
            boxes.Add(box);
        }

        public void RemoveBox(Box box)
        {
            boxes.Remove(box);
        }
    }
}
