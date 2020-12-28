using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFactory
{
    /// <summary>
    /// 简单工厂类, 负责 炒菜
    /// </summary>
    public class FoodSimpleFactory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("ShreddedPorkWithPotatoes"))
            {
                food = new ShreddedPorkWithPotatoes();
            }
            else if (type.Equals("TomatoScrambledEggs"))
            {
                food = new TomatoScrambledEggs();
            }

            return food;
        }
    }
}