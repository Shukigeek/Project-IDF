using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Artillery : AttackTools
    {
        public override string BombType { get; set; }
        public override int AmmunitionCapacity { get; set; }
        public override string EffectiveAgainst { get; set; }
        public Artillery(string bombType, int ammunitionCapacity, string effectiveAgainst)
        {
            BombType = bombType;
            AmmunitionCapacity = ammunitionCapacity;
            EffectiveAgainst = effectiveAgainst;
        }
    }
}
