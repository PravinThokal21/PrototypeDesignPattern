using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal class Employee : IEmployee
    {
        public void Display()
        {
            Console.WriteLine("This is employee class");
        }

        public IEmployee Clone()
        {
            return (IEmployee) MemberwiseClone();
        }
    }
}
