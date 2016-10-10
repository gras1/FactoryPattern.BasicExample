using System;

namespace FactoryPattern.BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array of creators
            var creators = new ICreator[] { new ConcreteCreatorA(), new ConcreteCreatorB() };

            // Iterate over creators and create products
            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
