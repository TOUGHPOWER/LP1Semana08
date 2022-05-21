using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class Settler:Unit
    {
        
        public override float Value {get;}
        public Settler(int health, int movement) 
        : base(health,movement)
        {
            Value = 5;
        }

        public void Move()
        {
            base.Move();
        }
    }
}