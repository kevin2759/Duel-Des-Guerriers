using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel_Des_Guerriers.classes
{
    internal class Guerrier
    {

        //attributs privé
        private string nom;
        private int pointsDeVie;
        private int nbDesAttaque;

        //constructeur
        public Guerrier(string nom, int pointsDeVie, int nbDesAttaque)
        {
            this.nom = nom;
            this.pointsDeVie = pointsDeVie;
            this.nbDesAttaque = nbDesAttaque;

        }
        
        // Getters
        public string Nom()
        {
            return this.nom;
        }

        public int PointsDeVie()
        {
            return this.pointsDeVie;
        }

        public int NbDesAttaque()
        {
            return this.nbDesAttaque;
        }

        //Setters
    }


       
}
