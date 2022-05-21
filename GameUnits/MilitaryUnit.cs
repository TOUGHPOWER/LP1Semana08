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

        public override int Health { get => base.Health; set => Health = base.Health + value; }
        public MilitaryUnit(int health, int movement, int attackPower, float value) 
        : base(health,movement,value)
        {
            AttackPower = attackPower;

            XP = 0;
            
            value = attackPower + xp;
        }

        public void Move()
        {
            base.Move();
        }
    }
}