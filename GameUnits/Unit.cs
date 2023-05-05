using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }

        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;

            Health = health;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Move()
        {
            Console.WriteLine(movement);
        }
    }
}