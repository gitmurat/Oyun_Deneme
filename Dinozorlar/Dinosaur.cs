using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    abstract class Dinosaur
    {
        public abstract string Type { get; }

        public abstract string livesIn { get; }
        public abstract bool CanFly { get; }
        public abstract bool CanSwim { get; }

        private int _Health { get; set; }
        public int Health
        {
            get
            {
                return _Health;
            }
            set
            {
                _Health = value;
            }
        }
        private int _Strength { get; set; }
        public int Strength
        {
            get
            {
                return _Strength;
            }
            set
            {
                _Strength = value;
            }
        }

        public abstract bool ResAcid { get; }
        public abstract bool ResCold { get; }
        public abstract bool ResHeat { get; }
        //public abstract bool IsHungry { get; } her tur otomatik beslenecek hiç aç kalmayacak
        public abstract bool IsPoisoned { get; }

        
        public abstract int HowMany { get; set; }
        
        public void Status ()
        {
            Console.WriteLine("");
            Console.WriteLine("Number of " + Type + ": " + HowMany);
            Console.WriteLine("Health of " + Type + ": " + Health);
            Console.WriteLine("Strenght of " + Type + ": " + Strength);
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
        }
        

        public int Procreate(Dinosaur dino1)
        {
            if (dino1.HowMany > 1)
            {
                decimal factor = 0.07m;
                decimal newnumber = dino1.HowMany * factor;
                return Decimal.ToInt32(newnumber);
            }
            else
            {
                return 0;
            }
        }

        public int[] Hunt(Dinosaur dino1, Dinosaur dino2) 
        {
            int[] healths = new int[2];
            if (dino1.Health > 0 && dino2.Health > 0)
            {
                while (dino1.Health > 0 && dino2.Health > 0)
                {
                    dino1.Health = dino1.Health - dino2.Strength;
                    dino2.Health = dino2.Health - dino1.Strength;
                }
                healths[0] = dino1.Health;
                healths[1] = dino2.Health;
                return healths;
            }
            
            else 
            { 
                healths[0] = dino1.Health;
                healths[1] = dino2.Health;
                return healths; }
        }


    }
}
