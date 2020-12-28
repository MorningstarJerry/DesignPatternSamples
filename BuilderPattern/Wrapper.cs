using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Wrapper : Packing
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}