using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static Factory GetFactory(string choice)
        {
            if (choice == "HongQiCarFactory")
            {
                return new HongQiCarFactory();
            }
            if (choice == "AoDiCarFactory")
            {
                return new AoDiCarFactory();
            }

            return null;
        }
    }
}