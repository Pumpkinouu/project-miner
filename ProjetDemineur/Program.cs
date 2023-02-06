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
            // Affcihe le titre
            Titre();

            // Affcihe les conditions de nombre de lignes et colonnes
            ConsigneDebut();

            // Demande a l'utilisateur les valeurs pour le tableau
            ConsigneTableau();





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
                Tableau(ligne);
                Console.ReadLine();

            }

            static void Tableau(int ligne)
            {

                for(int i = 0; i <= ligne-1; i++)
                {
                    //Début
                    if (i == 0)
                    {
                        Console.Write("╔═══╦");
                    }
                    if (i > 0 && i < ligne-1)
                    {
                        Console.Write("═══╦");
                    }
                    if (i == ligne-1)
                    {
                        Console.Write("═══╗");
                    }
                }

            }

        }
    }
}