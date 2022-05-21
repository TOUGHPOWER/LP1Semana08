using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit:Unit
    {
        public int AttackPower {get;}
        public int XP{get; set;}

        public MilitaryUnit(int health, int movement, int attackPower) : base(health,movement)
        {
            AttackPower = attackPower;

            XP = 0;

        }

        public void Move()
        {
            base.Move();
        }
    }
}