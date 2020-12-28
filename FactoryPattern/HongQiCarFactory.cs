using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 红旗汽车工厂类
    /// </summary>
    public class HongQiCarFactory : Factory
    {
        /// <summary>
        /// 负责生产红旗汽车
        /// </summary>
        /// <returns></returns>
        public override Car CreateCar()
        {
            return new HongQiCar();
        }
    }
}