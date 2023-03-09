using CSharpCombinatoricsOperations.Products;

namespace CSharpCombinatoricsOperations.Interfaces
{
    //Permutation factory interface
    internal interface IPermutationsFactory
    {
        //Method prototype of create product string permutations
        GetAllPermutationsOfStringProduct CreateProductStringPermutations();

        //Method prototype of create product number permutations
        GetAllPermutationsOfNumberProduct CreateProductNumberPermutations();

        //Method prototype of create product split collection
        SplitCollectionProduct CreateProductSplitCollection();
    }
}
