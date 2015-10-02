using System;

namespace Inheritance2
{
    class Staff : Employee
    {
        public override void Promote()
        {
            Console.WriteLine("Promoting a staff");
        }

    }
}