using System;

namespace Projet2
{
    class Program
    {
        static void Main(string[] args)
        {
            double longueur, largeur;
            Console.Out.WriteLine("\n\nRectangle 1 = ");
            Console.Out.Write("Donner la longueur du rectangle: ");
            longueur = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner la largeur du rectangle: ");
            largeur = double.Parse(Console.In.ReadLine());
            Rectangle R1 = new Rectangle(longueur, largeur);
            Console.Out.WriteLine("Le périmétre est " + R1.Perimetre());
            Console.Out.WriteLine("La surface est " + R1.Aire());
            if (R1.EstCarre())
                Console.Out.WriteLine("C'est un carré");
            else
                Console.Out.WriteLine("Ce n'est pas un carré");

            Console.Out.WriteLine("\n\nRectangle 2 = ");
            Console.Out.Write("Donner la longueur du rectangle: ");
            longueur = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner la largeur du rectangle: ");
            largeur = double.Parse(Console.In.ReadLine());

            Rectangle R2 = new Rectangle();
            R2.Longueur = longueur;
            R2.Largeur = largeur;
            R2.AfficherRectangle();

            Console.ReadKey();
        }
    }
}
