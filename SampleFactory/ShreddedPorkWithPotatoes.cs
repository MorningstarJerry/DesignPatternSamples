using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFactory
{
    /// <summary>
    /// 土豆肉丝这道菜
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("ShreddedPorkWithPotatoes");
        }
    }
}