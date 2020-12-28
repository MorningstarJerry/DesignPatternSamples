using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Bottle : Packing
    {
        public String pack()
        {
            return "Bottle";
        }
    }
}