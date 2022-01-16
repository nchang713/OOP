using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Car
    {
        // 顏色
        public string Color { get; set; }
        // 品牌
        public string Brand { get; set; }

        // 開車
        public void Drive()
        {
            // 發動引擎
            EngineOn();
            // 踩油門
            GasPedal();
        }

        // 發動引擎
        protected void EngineOn()
        {
            Console.WriteLine($"Engine on.");
        }

        // 踩油門
        private void GasPedal()
        {
            Console.WriteLine($"Step on the gas pedal.");
        }
    }
}
