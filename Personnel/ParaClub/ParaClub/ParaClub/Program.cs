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
            ConsoleKeyInfo keyPressed;

            Plane plane = new Plane();

            List<Para> parachutistsInTheAir = new List<Para>();

            for (int i = 0; i < 8; i++)
            {
                plane.parachutists.Add(new Para());
            }

            //bouger l'avion
            while (true)
            {
                Console.Clear();
                // Modifier le modèle (ce qui *est*)
                plane.update();

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;

                        case ConsoleKey.Spacebar:
                            Para jumper = plane.dropParachutist();
                            parachutistsInTheAir.Add(jumper);
                            break;
                        default:
                            break;
                    }
                }

                plane.update();
                foreach (Para para in parachutistsInTheAir)
                {
                    para.update();
                }
                //Ce qu'on voit
                plane.draw();
                foreach (Para para in parachutistsInTheAir)
                {
                    para.draw();
                }

                // Temporiser
                Thread.Sleep(100);
            }
            /*para.x = plane.x + 12;
            Console.SetCursorPosition(para.x, para.y);
            Console.Write(para.parachutiste);*/
        }
    }
}
