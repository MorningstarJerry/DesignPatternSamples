using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class Burger : Item
    {
        public virtual string name()
        {
            throw new NotImplementedException();
        }

        public Packing packing()
        {
            return new Wrapper();
        }

        public virtual float price()
        {
            throw new NotImplementedException();
        }
    }
}