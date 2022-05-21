using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class Settler
    {
        public Settler(int health, int movement, float value) 
        : base(health,movement, value)
        {
            value = 5;
        }

        public void Move()
        {
            base.Move();
        }
    }
}