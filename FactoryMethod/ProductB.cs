using FactoryMethod.Abstractions;

namespace FactoryMethod
{
    class ProductB : Product
    {
        public override string Name { get; } = nameof(ProductB);
    }
}
