namespace FactoryPattern.BasicExample
{
    public class ConcreteCreatorB : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}