using System;



namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random for the combination of colors
            Random random = new Random();





          
            string nom;





            // message bienvenue //
            
            Console.WriteLine("Mastermind Game");
           
            Console.WriteLine("");
            Console.Write("entrez votre nom: ");
            nom = Console.ReadLine();
            Console.WriteLine("bienvenue" + nom + ".");
            Console.WriteLine("vous voulez jouer? [o]");



            while (Console.ReadLine() == "o")
            {
                /*Est-ce le caractère utilisé pour initialiser la chaîne
                    dans la boucle while pour garantir que pas plus de 4 lettres sont générées */
                string secret = "";



                // Random combination de "RGBY" //
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
                // Secret Combination //
               Console.WriteLine($"secret est {secret}");



                // Instructions // 
                Console.WriteLine("Vous devez trouver la combinaison de couleurs secrète avec la lettre:");
              Console.WriteLine("R-G-B-Y");


                // Conditions gagner ou perdu //
                if (Console.ReadLine() == secret)
                {
                    
                    Console.WriteLine("gagner-bravo!");
                   
                    Console.WriteLine("vous voulez jouer encore? [o/n]");
                }
                else
                {
                    Console.WriteLine("perdu ");
                    Console.WriteLine("vous voulez jouer encore ? [o/n]");
                }



            }
        }
    }
}



