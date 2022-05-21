using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit soldier1 = new MilitaryUnit(100,2,20,1);
            Settler settler1 = new Settler(50,1);
            soldier1.Move();
            settler1.Move();
            Console.WriteLine(soldier1.Health);
            Console.WriteLine(settler1.Health);
            Console.WriteLine(soldier1.Value);
            Console.WriteLine(settler1.Value);
        }
    }
}
