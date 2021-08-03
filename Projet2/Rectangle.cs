using System;
using System.Collections.Generic;
using System.Text;

namespace Projet2
{
    class Rectangle
    {
        private double longueur;
        private double largeur;
        public double Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public double Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

       

        public Rectangle() { }
        public Rectangle(double lon, double larg)
        {
            this.longueur = lon;
            this.largeur = larg;
        }

        public double Perimetre()
        {
            return 2 * (longueur + largeur);
        }

        public double Aire()
        {
            return longueur * largeur;
        }

        public bool EstCarre()
        {
            if (longueur == largeur)
                return true;
            else
                return false;
        }

        public void AfficherRectangle()
        {
            string s = "";
            s += "- Longueur : " + longueur;
            s += "- Largeur : " + largeur;
            s += "- Périmétre : " + Perimetre();
            s += "- Aire : " + Aire();
            if (EstCarre())
                s += "- Il s'agit d'un carré";
            else
                s += "- Il ne s'agit pas d'un carré";

            Console.Out.WriteLine(s);
        }
    }
}
