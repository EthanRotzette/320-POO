using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public interface IDispatchable
    {
        bool PassBox(Box box);
        bool RemoveBox(Box box);
    }
}
