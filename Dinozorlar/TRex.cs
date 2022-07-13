using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    internal class TRex : Dinosaur
    {
        public override string Type => "T-Rex";
        public override string livesIn => "Land";
        public override bool CanFly => false;
        public override bool CanSwim => false;
        private int _Health { get; set; }
        public override int Health
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
        private int _Strength
        {
            get { return _Strength; }
            set
            {
                _Strength = 150;
            }
        }
        public override int Strength
        {
            get
            {
                return _Strength;
            }
        }
        public override bool ResAcid =>false;
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

