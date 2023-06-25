using FactoryMethod;
using FactoryMethod.Abstractions;

CreatorA creatorA = new();
CreatorB creatorB = new();

Product product1 = creatorA.CreateProduct();
Product product2 = creatorB.CreateProduct();

Console.WriteLine(product1.Name);
Console.WriteLine(product2.Name);