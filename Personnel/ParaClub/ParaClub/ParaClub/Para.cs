using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParaClub
{
    internal class Para
    {
        private string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
        };

        private string[] withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
        };

        private string _name;
        public int y = 4;
        public int x = 0;
        private const int PARA_HEIGHT = 7;
        public bool parachuteIsOpen;

        public string Name { get => _name; set => _name = value; }

        public void update()
        {
            if (y <= Config.SCREEN_HEIGHT - PARA_HEIGHT) // il est en l'air
            {
                if(parachuteIsOpen)
                {
                    y += 1;
                }
                else
                {
                    y += 3;
                }
                if (y >= Config.SCREEN_HEIGHT / 2)
                {
                    parachuteIsOpen = true;
                }
            }
            else
            {
                parachuteIsOpen = false;
            }
        }

        public void draw()
        {
            if (parachuteIsOpen)
            {
                for (int i = 0; i < withParachute.Length; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(withParachute[i]);
                }
            }
            else
            {
                for (int i = 0; i < withoutParachute.Length; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(withoutParachute[i]);
                };
            }
        }

    }
}
