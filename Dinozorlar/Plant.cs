using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    abstract class Plant
    {
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
        public abstract string Type { get; }
        public abstract bool ResAcid { get; }
        public abstract bool ResCold { get; }
        public abstract bool ResHeat { get; }
        public abstract bool IsPoisoned { get; }
        public abstract bool IsPoisonous { get; }
        public abstract int HowMany { get; set; }

        public void Status()
        {
            Console.WriteLine("");
            Console.WriteLine("Number of " + Type + ": " + HowMany);
            Console.WriteLine("Health of " + Type + ": " + Health);
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
        }

        public abstract void Procreate(Plant plant1);
    }
}

