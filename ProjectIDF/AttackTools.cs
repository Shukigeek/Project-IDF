using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal abstract class AttackTools
    {
        public abstract string BombType { get; set; }
        public abstract int AmmunitionCapacity { get; set; }
        public int FuelSupply { get; set; }
        public abstract string EffectiveAgainst { get; set; }

    }
}
