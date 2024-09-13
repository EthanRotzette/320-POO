using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        private Pen factoryBrush = new Pen(new SolidBrush(Color.Red), 20);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(factoryBrush, new Rectangle(X - 4, Y - 2, 16, 16));
        }
        public void Show()
        {
            Console.WriteLine("Factory");
        }
    }
}
