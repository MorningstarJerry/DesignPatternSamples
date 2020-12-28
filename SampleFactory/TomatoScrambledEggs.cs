using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFactory
{
    /// <summary>
    /// 西红柿炒鸡蛋这道菜
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("TomatoScrambledEggs");
        }
    }
}