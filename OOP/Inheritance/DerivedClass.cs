using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    class DerivedClass : BaseClass
    {
        public string NickName { get; set; }
        public string SchoolName { get; set; }

        // Overriding(覆寫)
        public override void SayHi() => Console.WriteLine($"Hello {NickName}");

        // Derived class constructor inherits base class.
        public DerivedClass() : base("Daniel")
        {
            base.Height = 175; // Set attribute of base class.
            base.SayHi(); // Call method of base class. Output: Hi Daniel
            this.Height = 170.5;
            this.NickName = "Andy"; // Set attribute of derived class.
            this.SchoolName = "NTU"; // Set attribute of derived class.
            this.SayHi(); // Call method of derived class. Output: Hello Andy
        }
    }
}
