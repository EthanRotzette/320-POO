﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public interface IDispatchable
    {
        void AddBox(Box box);
        void RemoveBox(Box box);
    }
}
