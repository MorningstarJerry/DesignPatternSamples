using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Coke : ColdDrink
    {
        public override float price()
        {
            return 30.0f;
        }

        public override string name()
        {
            return "Coke";
        }
    }
}