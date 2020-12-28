using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class Factory
    {
        // 工厂方法
        public abstract Car CreateCar();
    }
}