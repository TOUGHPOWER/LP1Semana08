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

        public override float Value {get;}

        public override int Health { get => base.Health; set => Health = base.Health + XP; }
        public MilitaryUnit(int health, int movement, int attackPower, int xp) 
        : base(health,movement)
        {
            AttackPower = attackPower;

            XP = 0;

            Value = attackPower + xp;
        }

        public void Move()
        {
            base.Move();
        }
    }
}