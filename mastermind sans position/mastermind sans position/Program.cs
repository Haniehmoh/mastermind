using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind_sans_position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'une instance de Random pour générer des combinaisons aléatoires
            Random random = new Random();

            // Message de bienvenue
            Console.WriteLine("Jeu Mastermind");
            Console.WriteLine("Bienvenue, ");
            Console.WriteLine("Vous devez trouver la combinaison de couleurs secrète avec les lettres : R - G - B - Y");

            // Variable pour déterminer si le joueur veut jouer encore
            bool jouerEncore = true;

            // Boucle principale du jeu
            do
            {
                // Variable pour déterminer si le joueur a perdu la partie
                bool perdu = true;

                // Boucle pour gérer les 10 tentatives
                for (int essai = 1; essai <= 10; essai++)
                {
                    string secret = "";

                    // Génération aléatoire de la combinaison de "RGBY"
                    for (int i = 0; i < 4; i++)
                    {
                        int x = random.Next(4);
                        if (x == 0)
                        {
                            secret = secret + 'R';
                        }
                        else if (x == 1)
                        {
                            secret = secret + 'G';
                        }
                        else if (x == 2)
                        {
                            secret = secret + 'B';
                        }
                        else if (x == 3)
                        {
                            secret = secret + 'Y';
                        }
                    }

                    // Affichage du numéro de l'essai en cours
                    Console.WriteLine($"Essai {essai} :");
                    string reponse = Console.ReadLine();

                    // Conditions de victoire ou de défaite avec sensibilité à la casse
                    if (reponse.Equals(secret, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Bravo, vous avez gagné !");
                        perdu = false; // Le joueur a gagné
                        break; // Sortir de la boucle car le jeu est gagné
                    }

                    if (essai < 10)
                    {
                        Console.WriteLine($"Il vous reste {10 - essai} essais.");
                    }
                }

                // Affichage du message de défaite si le joueur n'a pas gagné
                if (perdu)
                {
                    Console.WriteLine("Désolé, vous êtes perdu !");
                }

                // Demande au joueur s'il souhaite jouer encore
                Console.Write("Voulez-vous jouer encore ? (o/n) : ");
                string reponseJouerEncore = Console.ReadLine();
                jouerEncore = (reponseJouerEncore.ToLower() == "o");

            } while (jouerEncore);

            // Message de fin du jeu
            Console.WriteLine("Fin du jeu.");
        }
    }
}
