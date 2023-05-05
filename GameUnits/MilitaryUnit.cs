using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        

        public int AttackPower { get; }
        public int XP { get; private set; }

        public override float Cost => AttackPower + XP;

        public override int Health => base.Health + XP;

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health--;
        }
    }
}