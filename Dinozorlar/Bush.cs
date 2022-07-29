using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinozorlar
{
    internal class Bush : Plant
    {
        private int _HowMany { get; set; }
        public override int HowMany
        {
            get { return _HowMany; }
            set { _HowMany = value; }
        }

        public override bool IsPoisoned => false;
        public override bool ResAcid => false;
        public override bool ResCold => false;
        public override bool ResHeat => false;
        public override bool IsPoisonous => false;
        public override string Type => "Bush";

        public override void Procreate(Plant plant1)
        {
            if (plant1.HowMany > 1)
            {
                decimal factor = 0.1m;
                decimal newnumber = plant1.HowMany * factor;
                plant1.HowMany += Decimal.ToInt32(newnumber);
            }
        }
    }
}
