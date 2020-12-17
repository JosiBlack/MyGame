using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
   public class Goku : Personnage

    {
        public Goku (string nom) : base(nom)
        {
            pointsDeVie = 80;
            degatsMin = 10;
            degatsMax = 25;
            powerUp = 50;
        }
    }
}
