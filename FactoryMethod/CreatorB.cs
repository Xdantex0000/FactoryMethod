using FactoryMethod.Abstractions;

namespace FactoryMethod
{
    internal class CreatorB : Creator
    {
        public override Product CreateProduct()
        {
            return new ProductB();
        }
    }
}
