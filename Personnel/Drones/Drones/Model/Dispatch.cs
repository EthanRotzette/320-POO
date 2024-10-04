using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Dispatch : IDisposable
    {
        List<Box> boxes = new List<Box>();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
