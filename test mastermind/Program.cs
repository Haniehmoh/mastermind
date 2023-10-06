using System;
using System.ComponentModel;

namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //audeture : hanieh mohajerani
            // prof : M.Ferrai-module 403
            // date commencer:25.08.2023


            // Random for the combination of colors
            Random random = new Random();

            // message bienvenue et message entre //

            Console.WriteLine("BIENVENUE");
            Console.WriteLine("Couleurs possibles:GYWRBMC");
            Console.WriteLine("Devine le code en 4 coleurs: ");

           
            Console.WriteLine("vous voulez jouer? [o]");



            while (Console.ReadLine() == "o")
            {
                /*Est-ce le caractère utilisé pour initialiser la chaîne
                    dans la boucle while pour garantir que pas plus de 4 lettres sont générées */
                string secret = "";



                // Random combination de "RGBY" //
                for (int i = 0; i < 4; i++)
                {
                    int color = random.Next(4);
                    if (color == 0)
                    {
                        secret = secret + 'R';
                    }
                    else if (color == 1)
                    {
                        secret = secret + 'G';
                    }
                    else if (color == 2)
                    {
                        secret = secret + 'B';
                    }
                    else if (color == 3)
                    {
                        secret = secret + 'Y';
                    }
                }
                // Secret Combination //
              // Console.WriteLine($"secret est {secret}");



                // Instructions // 
               // Console.WriteLine("Vous devez trouver la combinaison de couleurs secrète avec la lettre:");
             // Console.WriteLine("R-G-B-Y");

                //condition pour essayer 10 fois
                for(int i =0;i <10; i++)
                {
                    Console.Write("essaie:" );
                    // Conditions gagner ou perdu //
                    if (Console.ReadLine() == secret)
                    {
                    
                        Console.WriteLine("gagner-bravo!");
                   
                        
                    }
                    else
                    {
                        Console.WriteLine("perdu ");
                        
                    }
                }
                Console.WriteLine("vous voulez jouer encore? [o/n]");
              


            }
        }
    }
}
/*int[] array1 ={1,2,3,4};
 * int[] array2 ={1,2,3,4};
 * bool areEqual = array1.SequenceEquel (array 2);
 * Console.WriteLine(AREeQUAL); */

/* string [] color1= randomcolor
 * string [] color 2 =secretcolor
 * string commoncolor =color =color.Intersecret(color);
 * ConsoleWriteLine("color juste" + commoncolor.count());
 * Console.ReadLine();



