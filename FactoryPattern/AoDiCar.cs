using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 奥迪汽车
    /// </summary>
    public class AoDiCar : Car
    {
        public override void Go()
        {
            Console.WriteLine("AoDi Start Runing ");
        }
    }
}