using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool EndTurn = false;
            string answer = "";
            TRex rex1 = new TRex();
            rex1.HowMany = 100;
            Raptor raptor1 = new Raptor();
            raptor1.HowMany = 200;


            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("Round: " + i);
                Console.WriteLine("Number of T-Rexes = " + rex1.HowMany);
                Console.WriteLine("Number of Raptors = " + raptor1.HowMany);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Would you like to end the turn? Y/N");
                answer = Console.ReadLine();
                if (answer == "Y")
                {
                    Console.WriteLine(rex1.Procreate(rex1));
                    Console.WriteLine(raptor1.Procreate(raptor1));
                    
                    rex1.HowMany += rex1.Procreate(rex1);
                    raptor1.HowMany += raptor1.Procreate(raptor1);

                    Console.WriteLine("Number of T-Rexes after Procreation = " + rex1.HowMany);
                    Console.WriteLine("Number of Raptors after Procreation = " + raptor1.HowMany);
                    Console.WriteLine("---------------------------------");

                    int [] NewHealth = rex1.Hunt(rex1, raptor1);
                    if (rex1.Health >= 0)
                    {
                        rex1.HowMany -= 1;
                    }
                    if (raptor1.Health <= 0)
                    {
                        raptor1.HowMany -= 1;
                    }

                    Console.WriteLine("Number of T-Rexes after Hunt = " + rex1.HowMany);
                    Console.WriteLine("Number of Raptors after Hunt = " + raptor1.HowMany);
                    Console.WriteLine("---------------------------------");

                    raptor1.Hunt(raptor1, rex1);
                    if (rex1.Health >= 0)
                    {
                        rex1.HowMany -= 1;
                    }
                    if (raptor1.Health <= 0)
                    {
                        raptor1.HowMany -= 1;
                    }
                    Console.WriteLine("Number of T-Rexes after Hunt = " + rex1.HowMany);
                    Console.WriteLine("Number of Raptors after Hunt = " + raptor1.HowMany);
                    Console.WriteLine("---------------------------------");
                    
                }


                else if (answer == "N")
                {
                    Console.WriteLine("Waiting to end turn");
                    i -= 1;
                    
                }


                else
                {
                    Console.WriteLine("Please enter Y to end turn or N to wait.");
                    i -= 1;
                    
                }
            }


        }
    }
}
