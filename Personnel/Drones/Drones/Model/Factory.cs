using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        private double _powerConsumption = 0;
        private int _id;
        private int _productionTime = 50;

        public double PowerConsumption { get => _powerConsumption; set => _powerConsumption = value; }
        public int Id { get => _id; set => _id = value; }

        public Factory(double powerConsumption)
        {
            PowerConsumption = powerConsumption;
        }

        public void Update(int interval)
        {
            if(_productionTime == 0)
            {
                Console.WriteLine("Un carton est créé");
                _productionTime += MiscHelpers.AleaTime();
            }
            else
            {
                _productionTime--;
            }
        }
    }
}
