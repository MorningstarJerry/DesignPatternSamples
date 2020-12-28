using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class ColdDrink : Item
    {
        public virtual string name()
        {
            throw new NotImplementedException();
        }

        public Packing packing()
        {
            return new Bottle();
        }

        public virtual float price()
        {
            throw new NotImplementedException();
        }
    }
}