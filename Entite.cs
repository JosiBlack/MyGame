using System;
namespace MyGame
{
    public class Entite
    {
        protected String nom;
        protected bool estMort = false;
        protected int degatsMin;
        protected int degatsMax;
        protected Random random = new Random();
        private string pointsDeVie;

        // public pointsDeVie;

        public Entite(string nom){

            this.nom = nom;
        }

        public void Attaquer(Entite uneEntite)
        {
            //int pointsDeVie;
            int degats = random.Next(degatsMin, degatsMax);
            uneEntite.perdrePointDeVie(degats);
            Console.WriteLine(this.nom + "(" + this.pointsDeVie + ")" + "attaque:" + uneEntite.nom);
            Console.WriteLine(uneEntite.nom + "a perdu" + degats + "points  de vie");
            Console.WriteLine("il reste " + uneEntite.pointsDeVie + "points de vie a " + uneEntite.nom);

            // la mort d'un personnage

            if (uneEntite.estMort)
            {
                Console.WriteLine(uneEntite.nom + "est mort");
            }
        }

        protected void perdrePointDeVie(int pointsDeVie)
        {

        }

        public bool EstMort()
        {
            return this.estMort;
        }
    }
}
