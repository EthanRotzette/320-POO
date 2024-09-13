using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        private Pen storeBrush = new Pen(new SolidBrush(Color.Red), 16);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(storeBrush, new Rectangle(X - 4, Y - 2, 16, 16));
        }
        public void Show()
        {
            Console.WriteLine("Store");
        }
    }
}
