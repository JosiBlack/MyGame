using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    public class Monstre:Entite
    {
        public Monstre(string nom) : base(nom)
        {
            this.nom = nom;
            pointsDeVie = 60;
            degatsMin = 5;
            degatsMax = 10;
        }
    }
}
