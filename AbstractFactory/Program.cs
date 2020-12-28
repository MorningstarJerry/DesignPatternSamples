using System;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 初始化创建汽车的两个工厂
            Factory hongQiCarFactory = FactoryProducer.GetFactory("HongQiCarFactory");
            Factory aoDiCarFactory = FactoryProducer.GetFactory("AoDiCarFactory");

            // 生产一辆红旗汽车
            Car hongQi = hongQiCarFactory.CreateCar();
            hongQi.Go();

            //生产一辆奥迪汽车
            Car aoDi = aoDiCarFactory.CreateCar();
            aoDi.Go();

            Console.Read();
        }
    }
}