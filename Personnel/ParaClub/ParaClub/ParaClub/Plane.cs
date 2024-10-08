﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ParaClub
{
    internal class Plane
    {
        public int x = 0;
        public int y = 0;

        public List<Para> parachutists = new List<Para>();

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        // Model attributes
        public int altitude;

        /// <summary>
        /// Constructor
        /// </summary>
        public Plane()
        {
            x = 0;
            altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(view[i]);
            }
        }

        public void update()
        {
            x++;
            //ce controle doit être effectué pour savoir quand l'avion est au bout de la fenêtre
            if (x > Console.WindowWidth - view[0].Length)
            {
                x = 0; //remet x a 0 quand 
            }
        }
        /// <summary>
        /// Take a parachustist on board
        /// </summary>
        /// <param name="para"></param>
        public void board(Para para)
        {
            this.parachutists.Add(para);
        }

        internal Para dropParachutist()
        {
            /*if (parachutists == null)
            { }*/
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.x = x;
            parachutist.y = this.y;
            return parachutist;
        }
    }
}
