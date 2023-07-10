using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal interface IEmployee
    {
        public void Display();
        public IEmployee Clone();
    }
}
