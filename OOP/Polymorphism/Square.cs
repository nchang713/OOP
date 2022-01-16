using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Square : Shape
    {
        public override void Draw()
        {
            // Code to draw a square..
            Console.WriteLine("Drawing a square");
            base.Draw();
        }
    }
}
