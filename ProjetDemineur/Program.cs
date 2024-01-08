/// ETML
/// Auteur : Danilo Zivanovic
/// Date   : 16.01.2023
/// Description :
namespace ProjetDemineur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ligne = 0;
            int colonne = 0;
            // Affcihe le titre
            Titre();

            // Affcihe les conditions de nombre de lignes et colonnes
            ConsigneDebut();

            // Demande a l'utilisateur les valeurs pour le tableau
            ConsigneTableau();

            // Permet d'afficher le tableau du demineur
            Tableau(ligne, colonne);
        }




        /// <summary>
        /// Affichage du titre principal
        /// </summary>
        static void Titre()
        {

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("*                   Démineur simplifié (Danilo Zivanovic)                   *");
            Console.WriteLine("*****************************************************************************\n");
        }

        /// <summary>
        /// Affichage des condition de nombre de lignes et colonnes
        /// </summary>
        static void ConsigneDebut()
        {

            Console.WriteLine("   Merci d'entrer le nombre de ligne et de colonne de votre plateau de jeux");
            Console.WriteLine("   en sachant qu'au minimum on a plateau de 6 lignes x 6  colonens ! ");
            Console.WriteLine("   et au maximum un plateau de 30 lignes x 30 colonnes !");
            Console.WriteLine("-----------------------------------------------------------------------------\n");
        }

        /// <summary>
        /// Demande les valeurs a l'utilisateur
        /// </summary>
        static void ConsigneTableau()
        {
            int ligne = 0;
            int colonne = 0;
            int dificulte;
            bool valueOk = true;


            do
            {
                Console.Write("\nNombre de ligne : ");

                if (!(int.TryParse(Console.ReadLine(), out ligne)))
                {
                    Console.WriteLine("Votre valeur n'est pas un nombre ! Merci de réessayer");
                }

                else if (ligne < 6 || ligne > 30)
                {
                    Console.WriteLine("\nValeur hors limite ! Merci de réessayer !");
                }

                else if (ligne > 6 || ligne < 30)
                {
                    break;
                }

            } while (valueOk);

            do
            {
                Console.Write("\nNombre de colonne : ");

                if (!(int.TryParse(Console.ReadLine(), out colonne)))
                {
                    Console.WriteLine("Votre valeur n'est pas un nombre ! Merci de réessayer");
                }

                else if (colonne < 6 || colonne > 30)
                {
                    Console.WriteLine("\nValeur hors limite ! Merci de réessayer !");
                }

                else if (colonne > 6 || colonne < 30)
                {
                    break;
                }

            } while (valueOk);

            Console.WriteLine("\n-----------------------------------------------------------------------------\n\tMerci d'entrer la difficulté pour votre jeu\n\ten sachant que :\n\t\t1 --> niveau facile\n\t\t2--> niveau moyen\n\t\t3 --> niveau difficile");
            Console.Write("-----------------------------------------------------------------------------\n");

            do
            {
                Console.Write("\nvotre difficulté : ");

                if (!(int.TryParse(Console.ReadLine(), out dificulte)))
                {
                    Console.WriteLine("Votre valeur n'est pas un nombre ! Merci de réessayer");
                }

                else if (dificulte <= 0 || dificulte >= 4)
                {
                    Console.WriteLine("\nValeur hors limite ! Merci de réessayer !");
                }

                else if (dificulte >= 1 || dificulte <= 3)
                {
                    break;
                }

            } while (valueOk);

            Console.WriteLine();
            Tableau(ligne, colonne);
            Console.ReadLine();

        }

        static void Tableau(int ligne, int colonne)
        {
            for (int i = 0; i <= ligne - 1; i++)
            {
                if (i == 0)
                {
                    for (int e = 0; e <= colonne - 1; e++)
                    {

                        if (e == 0)
                        {
                            Console.Write("╔═══╦");
                        }
                        if (e > 0 && e < colonne - 1)
                        {
                            Console.Write("═══╦");
                        }
                        if (e == colonne - 1)
                        {
                            Console.Write("═══╗");
                            Console.WriteLine();

                        }
                    }
                    for (int d = 0; d <= colonne - 1; d++)
                    {
                        if (d == 0)
                        {
                            Console.Write("║   ");
                        }
                        if (d > 0 && d < colonne - 1)
                        {
                            Console.Write("║   ");
                        }
                        if (d == colonne - 1)
                        {
                            Console.Write("║   ║");
                            Console.WriteLine();

                        }
                    }
                }
                if (i == ligne - 1)
                {
                    for (int e = 0; e <= colonne - 1; e++)
                    {
                        if (e == 0)
                        {
                            Console.Write("╚═══");
                        }
                        if (e > 0 && e < colonne - 1)
                        {
                            Console.Write("╩═══");
                        }
                        if (e == colonne - 1)
                        {
                            Console.Write("╩═══╝");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    for (int e = 0; e <= colonne - 1; e++)
                    {
                        if (e == 0)
                        {
                            Console.Write("╠═══");
                        }
                        if (e > 0 && e < colonne - 1)
                        {
                            Console.Write("╬═══");
                        }
                        if (e == colonne - 1)
                        {
                            Console.Write("╬═══╣");
                            Console.WriteLine();

                        }
                    }
                    for (int d = 0; d <= colonne - 1; d++)
                    {
                        if (d == 0)
                        {
                            Console.Write("║   ");
                        }
                        if (d > 0 && d < colonne - 1)
                        {
                            Console.Write("║   ");
                        }
                        if (d == colonne - 1)
                        {
                            Console.Write("║   ║");
                            Console.WriteLine();

                        }
                    }
                }
            }
        }
    }
}
