using FactoryMethod.Abstractions;

namespace FactoryMethod
{
    class CreatorA : Creator
    {
        public override Product CreateProduct()
        {
            return new ProductA();
        }
    }
}
