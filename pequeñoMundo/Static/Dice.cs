using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequeñoMundo.Static
{
    internal static class Dice
    {
        static Random RandomSide = new Random();
        public static int TrowDice(int cantidadCaras)
        {
            return RandomSide.Next(1, cantidadCaras);
        }
    }
}
