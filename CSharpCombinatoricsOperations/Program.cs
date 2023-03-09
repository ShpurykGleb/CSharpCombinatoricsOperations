using CSharpCombinatoricsOperations.Factories;
using CSharpCombinatoricsOperations.Products;

PermutationsFactory factory = new PermutationsFactory();

SplitCollectionProduct product = factory.CreateProductSplitCollection();


List<int> list = new List<int> { 1, 5, 6, 7, 8, 9, 10, 25 };

var result = product.Split(list, 3).ToList();

foreach (List<int> partition in result)
{
    Console.WriteLine(string.Join(", ", partition));
}