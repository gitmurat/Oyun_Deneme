using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    internal class Results
    {
        public static void TurnResults(int round)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Round " + round + " Results");
            Console.WriteLine("----------------------------");
        }

        public static void ProcreateResults(Dinosaur dino1)
        {
            Console.WriteLine("Number of " + dino1.Type +" after Procreation= " + dino1.HowMany);
            Console.WriteLine("----------------------------");
        }

        public static void HuntResults(Dinosaur dino1, Dinosaur dino2)
        {
            Console.WriteLine("Number of " + dino1.Type + " after Hunt = " + dino1.HowMany);
            Console.WriteLine(dino1.Type + " Health: " + dino1.Health);
            Console.WriteLine("Number of " + dino2.Type + " after Hunt = " + dino2.HowMany);
            Console.WriteLine(dino2.Type + " Health: " + dino2.Health);
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void GrazeResults(Dinosaur dino1 , Plant plant1)
        {
            Console.WriteLine(dino1.Type + " finished grazing.");
            Console.WriteLine(dino1.Type + " Health: " + dino1.Health);
        }
    }
}
