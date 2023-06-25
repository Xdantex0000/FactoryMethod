using FactoryMethod.Abstractions;

namespace FactoryMethod
{
    class ProductA : Product
    {
        public override string Name { get; } = nameof(ProductA);
    }
}
