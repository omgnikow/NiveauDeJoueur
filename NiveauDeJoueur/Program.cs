using System;
using System.Globalization;

namespace NiveauDuJoueur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Saisie le niveau du personnage
            Console.Write("Entrez le niveau du personnage : ");
            int niveau = int.Parse(Console.ReadLine());

            // Saisie la classe principale de votre personnage
            Console.WriteLine("Choisissez la classe principale de votre personnage :");
            Console.WriteLine("1 - Guerrier");
            Console.WriteLine("2 - Mage");
            Console.WriteLine("3 - Rogue");
            Console.Write("Entrez votre choix (1-3) : ");
            int classe = int.Parse(Console.ReadLine());

            // Saisie le nombre Quêtes Héroïques accomplies
            Console.Write("Entrez le nombre de Quêtes Héroïques accomplies : ");
            int quetes = int.Parse(Console.ReadLine());


            // Calcul du titre du héros selon les règles du Conseil de Guilde
            string titreFinal;

            // Classe: 1=Guerrier, 2=Mage, 3=Rogue
            bool isGuerrier = (classe == 1);
            bool isMage = (classe == 2);
            bool isRogue = (classe == 3);

            if (niveau < 10)
            {
                titreFinal = "Novice";
            }
            else if (niveau >= 10 && niveau <= 20)
            {
                if (quetes >= 5)
                    titreFinal = "Adepte";
                else
                    titreFinal = "Apprenti assermenté";
            }
            else if (niveau >= 30)
            {
                // Maître de Guilde : niveau >=30, quêtes >20 et classe Guerrier ou Mage
                if (quetes > 20 && (isGuerrier || isMage))
                    titreFinal = "Maître de Guilde";
                else
                    // Ne remplit pas les conditions de Maître -> évaluer autres statuts
                    titreFinal = "Statut Indéterminé / Hors-la-loi";
            }
            else // niveau > 20 && niveau < 30
            {
                // Vétéran : niveau >20 et <30, ou Mage avec niveau >=25
                if ((niveau > 20 && niveau < 30) || (isMage && niveau >= 25))
                    titreFinal = "Vétéran";
                else
                    titreFinal = "Statut Indéterminé / Hors-la-loi";
            }

            Console.WriteLine(titreFinal);

        }
    }
}