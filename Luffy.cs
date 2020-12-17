using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
   public class Luffy : Personnage

    {
        public Luffy(string nom) : base(nom)
        {
            pointsDeVie = 120;
            degatsMin = 10;
            degatsMax = 15;
        }
    }
}
