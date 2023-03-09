namespace CSharpCombinatoricsOperations.Interfaces
{
    //Split collection interface
    internal interface ISplitCollection
    {
        //Method prototype of split collection
        List<List<T>> Split<T>(List<T> values, int chunkSize);
    }
}
