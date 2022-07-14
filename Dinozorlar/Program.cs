using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    
    internal class Program
    {
        static void TurnResults(int round)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Round " + round + " Results");
            Console.WriteLine("----------------------------");
        }

        static void Main(string[] args)
        {
            string answer = "";


            TRex rex1 = new TRex();
            rex1.HowMany = 100;
            rex1.Health = 350;
            rex1.Strength = 150;


            Raptor raptor1 = new Raptor();
            raptor1.HowMany = 200;
            raptor1.Health = 200;
            raptor1.Strength = 80;


            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("Round: " + i + " Beginning");
                rex1.Status();
                raptor1.Status();
                Console.WriteLine("Would you like to end the turn? Y/N");
                answer = Console.ReadLine();
                
                TurnResults(i);

                int[] NewHealth;
                if (answer == "Y")
                {
                    rex1.HowMany += rex1.Procreate(rex1);
                    raptor1.HowMany += raptor1.Procreate(raptor1);

                    Console.WriteLine("Number of T-Rex after Procreation= " + rex1.HowMany);
                    Console.WriteLine("Number of Rapotors after Procreation= " + raptor1.HowMany);
                    Console.WriteLine("----------------------------");

                    NewHealth = rex1.Hunt(rex1, raptor1);
                    rex1.Health = NewHealth[0];
                    raptor1.Health = NewHealth[1];
                    if (rex1.Health <= 0)
                    {
                        rex1.HowMany = rex1.HowMany - 1;
                        rex1.Health = 350;
                    }
                    

                    if (raptor1.Health <= 0)
                    {
                        raptor1.HowMany = raptor1.HowMany - 1;
                        raptor1.Health = 200;
                    }

                    Console.WriteLine("Number of T-Rexes after Hunt = " + rex1.HowMany);
                    Console.WriteLine("T-Rex Health: " + rex1.Health);
                    Console.WriteLine("Number of Raptors after Hunt = " + raptor1.HowMany);
                    Console.WriteLine("Raptors Health: " + raptor1.Health);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
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
