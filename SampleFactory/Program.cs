using System;

namespace SampleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 客户想点一个西红柿炒蛋
            Food food1 = FoodSimpleFactory.CreateFood("ShreddedPorkWithPotatoes");
            food1.Print();

            // 客户想点一个土豆肉丝
            Food food2 = FoodSimpleFactory.CreateFood("TomatoScrambledEggs");
            food2.Print();

            Console.Read();
        }
    }
}