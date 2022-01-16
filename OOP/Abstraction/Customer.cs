using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public void Save()
        {

        }

        public void Delete()
        {

        }
    }
}
