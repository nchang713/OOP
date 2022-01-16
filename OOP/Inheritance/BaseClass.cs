using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    class BaseClass
    {
        public string Name { get; set; } = string.Empty;
        public double Height { get; set; }

        // Virtual method(虛擬方法), which are allowed to be overrideden.
        public virtual void SayHi() => Console.WriteLine($"Hi {Name}");

        // Constructor overloading(建構子多載) 
        public BaseClass(string name)
        {
            Name = name;
        }

        public BaseClass()
        {
            Name = "Robot";
        }
    }
}
