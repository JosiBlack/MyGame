using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
   public class Naruto : Personnage
    {
        public Naruto (string nom) : base(nom)
        {
            pointsDeVie = 105;
            degatsMin = 15;
            degatsMax = 20;
        }
    }
}
