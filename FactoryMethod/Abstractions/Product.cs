namespace FactoryMethod.Abstractions
{
    abstract class Product
    {
        public virtual string Name { get; } = nameof(Product);
    }
}
