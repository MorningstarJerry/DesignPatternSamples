using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 红旗汽车
    /// </summary>
    public class HongQiCar : Car
    {
        public override void Go()
        {
            Console.WriteLine("HongQi Start Runing ！");
        }
    }
}