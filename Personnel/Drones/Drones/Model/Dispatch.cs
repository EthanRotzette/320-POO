using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Dispatch : IDispatchable
    {
        public List<Box> boxes = new List<Box>();

        public void AddBox(Box box)
        {
            boxes.Add(box);
            Console.WriteLine("Un carton est disponible");
        }

        public void RemoveBox(Box box)
        {
            boxes.Remove(box);
        }
    }
}
