using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGame
{
   public abstract class Personnage : Entite
    {
        private int niveau;
        private int experience;
        public Personnage(string nom) : base(nom)
        {
            this.nom = nom;
            niveau = 1;
            experience = 0;
        }
        
        public void gagnerExperience(int experience)
            // gagner en experience 
        {
            this.experience  += experience; 
            while (this.experience >= experienceRequise())
            {
                niveau += 1;
                Console.ForegroundColor = Console.purple;// choisir la couleur d'affichage
                Console.WriteLine("Bravo : Vous avez atteint le viveau " + niveau + "!");
                pointsDeVie += 15;
                degatsMin += 2;
                degatsMax += 5;
            }
        }
        public double experienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5)); //experience requise pour monter d'un niveau 2 a 3 ainsi de suite  
        }

        public void caracteristiques()
        {
            return this.nom + "\n" +"Points de vie:"+ pointsDeVie + "\n"+
                "Niveau:" + niveau +"\n" +
                "Points d'experience: (" + experience +"/" + experienceRequise() + ")\n" +
                "Dégats:[" + degatsMin + ";" + degatsMax + "]";
        }
    }
}
