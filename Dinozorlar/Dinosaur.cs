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
        public abstract bool IsCarnivore { get; }
        public abstract string livesIn { get; }
        public abstract bool CanFly { get; }
        public abstract bool CanSwim { get; }
        public abstract int MaxHealth { get; }

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

        public void Status()
        {
            Console.WriteLine("");
            Console.WriteLine("Number of " + Type + ": " + HowMany);
            Console.WriteLine("Health of " + Type + ": " + Health);
            Console.WriteLine("Strenght of " + Type + ": " + Strength);
            Console.WriteLine("Max Health of " + Type + ": " + MaxHealth);
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
        }


        public static void Procreate(Dinosaur dino1)
        {
            if (dino1.HowMany > 1)
            {
                decimal factor = 0.07m;
                decimal newnumber = dino1.HowMany * factor;
                dino1.HowMany += Decimal.ToInt32(newnumber);
            }
        }

        public static void Hunt(Dinosaur dino1, Dinosaur dino2) //should be put in new interface of "carnivore"
        {
            bool huntingseason = true;
            if (huntingseason && dino1.IsCarnivore)
            {
                while (dino1.Health > 0 && dino2.Health > 0)
                {
                    dino1.Health = dino1.Health - dino2.Strength;
                    dino2.Health = dino2.Health - dino1.Strength;
                    if (dino1.Health < 0 || dino2.Health < 0)
                    { huntingseason = false; break; }
                }
            }
            if (dino1.Health <= 0)
            {
                dino1.HowMany = dino1.HowMany - 1;
                dino1.Health = dino1.MaxHealth;
            }
            if (dino2.Health <= 0)
            {
                dino2.HowMany = dino2.HowMany - 1;
                dino2.Health = dino2.MaxHealth;
            }
        }

        public static void Graze(Dinosaur dino1, Plant plant1) //should be put in new interface "herbivore"
        {
            if (!dino1.IsCarnivore)
            {
                if (dino1.Health < dino1.MaxHealth)
                {
                    decimal healthfactor = 0.25m;
                    decimal newnumber = plant1.Health * healthfactor;
                    dino1.Health += Decimal.ToInt32(newnumber);
                }
                plant1.HowMany -= 1;
            }
                
        }
        /*public static void Eat() should check if dinosaur is carnivore or not and call either Hunt() or Graze()
        {
            if 
        }*/
    }
}
