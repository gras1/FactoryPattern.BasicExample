﻿namespace FactoryPattern.BasicExample
{
    public class ConcreteCreatorA : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}