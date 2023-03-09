using CSharpCombinatoricsOperations.Interfaces;

namespace CSharpCombinatoricsOperations.Products
{
    //Split collection product
    internal class SplitCollectionProduct : ISplitCollection
    {
        //Method, that split collection into n parts
        public List<List<T>> Split<T>(List<T> values, int chunkSize)
        {
            if (chunkSize <= 0)
            {
                return new List<List<T>>();
            }

            return values.Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}
