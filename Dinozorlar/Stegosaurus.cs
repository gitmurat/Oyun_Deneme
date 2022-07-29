using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    internal class Stegosaurus : Dinosaur
    {
        public override string Type => "Stegosaurus";
        public override string livesIn => "Land";
        public override bool CanFly => false;
        public override bool CanSwim => false;
        public override bool IsCarnivore => false;


        public override int MaxHealth
        {
            get
            { return 700; }

        }

        public override bool ResAcid => false;
        public override bool ResCold => false;
        public override bool ResHeat => false;
        public override bool IsPoisoned => false;


        private int _HowMany { get; set; }
        public override int HowMany
        {
            get { return _HowMany; }
            set { _HowMany = value; }
        }
    }
}

