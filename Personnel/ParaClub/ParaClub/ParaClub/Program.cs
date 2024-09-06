using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //définis la taille de l'écran
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            Plane plane = new Plane();
            Para para = new Para();

            para.Name = "Bob";
            plane.draw();
            plane.parachutistes.Add(para);

            //bouger l'avion
            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();

                para.update();

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();
                para.draw();

                // Temporiser
                Thread.Sleep(100);
            }
            /*para.x = plane.x + 12;
            Console.SetCursorPosition(para.x, para.y);
            Console.Write(para.parachutiste);*/
        }
    }
}
