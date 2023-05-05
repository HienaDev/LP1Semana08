using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {

        public override float Cost => 5;

        public SettlerUnit() : base(1, 2)
        {
        }

    }
}