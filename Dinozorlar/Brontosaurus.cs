using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    internal class Brontosaurus : Dinosaur
    {
        public override string Type => "Brontosaurus";
        public override string livesIn => "Land";
        public override bool CanFly => false;
        public override bool CanSwim => false;
        public override bool IsCarnivore => true;

        public override int MaxHealth
        {
            get
            { return 850; }

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
