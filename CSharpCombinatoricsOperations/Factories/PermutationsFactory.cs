using CSharpCombinatoricsOperations.Interfaces;
using CSharpCombinatoricsOperations.Products;

namespace CSharpCombinatoricsOperations.Factories
{
    //Permutations factory
    internal class PermutationsFactory : IPermutationsFactory
    {
        //Method, that creates object of GetAllPermutationsOfStringProduct
        public GetAllPermutationsOfStringProduct CreateProductStringPermutations() => new GetAllPermutationsOfStringProduct();

        //Method, that creates object of GetAllPermutationsOfNumberProduct
        public GetAllPermutationsOfNumberProduct CreateProductNumberPermutations() => new GetAllPermutationsOfNumberProduct();

        //Method, that creates object of SplitCollectionProduct
        public SplitCollectionProduct CreateProductSplitCollection() => new SplitCollectionProduct();
    }
}
