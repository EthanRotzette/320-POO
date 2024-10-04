using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public interface IDispatchable
    {
        void PassBox(Box box);
        void RemoveBox(Box box);
    }
}
