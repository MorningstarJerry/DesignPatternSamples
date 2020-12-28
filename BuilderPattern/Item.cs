using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface Item
    {
        public String name();

        public Packing packing();

        public float price();
    }
}