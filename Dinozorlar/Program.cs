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
            string answer = "";

            #region Instantiation
            TRex rex1 = new TRex();
            rex1.HowMany = 100;
            rex1.Health = 350;
            rex1.Strength = 250;


            Raptor raptor1 = new Raptor();
            raptor1.HowMany = 200;
            raptor1.Health = 200;
            raptor1.Strength = 150;

            Triceratops trice1 = new Triceratops();
            trice1.HowMany = 300;
            trice1.Health = 400;
            trice1.Strength = 40;

            Stegosaurus steg1 = new Stegosaurus();
            steg1.HowMany = 200;
            steg1.Health = 400;
            steg1.Strength = 70;

            Tree tree1 = new Tree();
            tree1.Health = 50;
            tree1.HowMany = 500;

            Bush bush1 = new Bush();
            bush1.Health = 20;
            bush1.HowMany = 1000;
            #endregion

            for (int i = 0; i < 200; i++)
            {
                #region Startturn:
                Console.WriteLine("Round: " + i + " Beginning");
                rex1.Status();  //all instances should be put in a list and Status() should be called with foreach
                raptor1.Status();
                trice1.Status();
                steg1.Status();
                tree1.Status();
                bush1.Status();
                Console.WriteLine("Would you like to end the turn? Y/N");
                answer = Console.ReadLine();
                #endregion

                Results.TurnResults(i);

                if (answer == "Y")
                {
                    Dinosaur.Procreate(rex1); //should be handled with List
                    Results.ProcreateResults(rex1);
                    Dinosaur.Procreate(raptor1);
                    Results.ProcreateResults(raptor1);
                    Dinosaur.Procreate(trice1);
                    Results.ProcreateResults(trice1);
                    Dinosaur.Procreate(steg1);
                    Results.ProcreateResults(steg1);

                    Dinosaur.Hunt(rex1, steg1); //Should be handled with randomized queue
                    Results.HuntResults(rex1, steg1);
                    Dinosaur.Hunt(raptor1, trice1);
                    Results.HuntResults(raptor1, trice1);

                    Dinosaur.Graze(steg1, tree1);
                    Results.GrazeResults(steg1, tree1);
                    Dinosaur.Graze(trice1, bush1);
                    Results.GrazeResults(trice1, bush1);
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
