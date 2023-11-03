using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace mastermind_position
{
    internal class Program
    {
        static void Main(string[] args)



        /*Créer le jou mastermind avec les colores secrets et random
         prof:Jonathan Melly
         par :Hanieh Mohajerani
        date de commence:08.09.2023*/



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
                Console.WriteLine(secret);
                // Boucle pour gérer les 10 tentatives
                for (int essai = 1; essai <= 10; essai++)
                {




                    // Affichage du numéro de l'essai en cours
                    Console.WriteLine($"Essai {essai} :");
                    string answer = Console.ReadLine();



                    // Vérification de la réponse et calcul des valeurs correctes
                    int correctColors = 0;
                    int correctPositions = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (answer[i] == secret[i])
                        {
                            correctPositions++;
                        }

                    }

                    //B
                    int bInSecret = 0;
                    int bInAnswer = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        //compter dans secret
                        if (secret[i] == 'B')
                        {
                            bInSecret = bInSecret + 1;
                        }
                        else if (secret[i] == 'R')
                        {
                            bInSecret = bInSecret + 2;
                        }
                        else if (secret[i] == 'Y')
                        {
                            bInSecret = bInSecret + 3;
                        }
                        else if (secret[i] == 'G')
                        {
                            bInSecret = bInSecret + 4;
                        }
                        //compter dans reponse
                        if (bInAnswer == 'B')
                        {
                            bInAnswer = bInAnswer + 'B';
                        }
                        else if (bInAnswer == 'R')
                        {
                            bInAnswer = bInAnswer + 'R';
                        }
                        else if (bInAnswer == 'Y')
                        {
                            bInAnswer = bInAnswer + 'Y';
                        }
                        else if (bInAnswer == 'G')
                        {
                            bInAnswer = bInAnswer + 'G';
                        }



                    }
                    //ajouter
                    int bValidColorsCount = Math.Min(bInAnswer, bInSecret);
                    correctColors = correctColors + bValidColorsCount;





                    // Affichage des résultats
                    Console.WriteLine($"OK={correctColors} couleur correcte");
                    Console.WriteLine($"Poition={correctPositions} position correcte");



                    // Conditions de victoire ou de défaite avec sensibilité à la casse
                    if (correctPositions == 4)
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
