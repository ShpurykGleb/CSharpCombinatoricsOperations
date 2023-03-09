using CSharpCombinatoricsOperations.Interfaces;

namespace CSharpCombinatoricsOperations.Products
{
    //Get all permutations of number product
    internal class GetAllPermutationsOfNumberProduct : INumberProductPermutation
    {
        //Method, that gets permutations of number
        private void GetPermutations(int remain, int maxTerm, List<int> terms, ref List<string> partitions)
        {
            if (remain == 0)
            {
                partitions.Add(string.Join(" + ", terms));
            }

            for (int term = maxTerm; term >= 1; term--)
            {
                if (term <= remain)
                {
                    terms.Add(term);
                    GetPermutations(remain - term, term, terms, ref partitions);
                    terms.Remove(term);
                }
            }
        }

        //Method, that returns all of permutaions of number
        public List<string> GetAllPermutationsOfNumber(int number)
        {
            List<string> partitions = new List<string>();

            if (number > 0)
            {
                int remain = number;
                int maxTerm = number;

                List<int> terms = new List<int>();

                GetPermutations(remain, maxTerm, terms, ref partitions);
            }

            return partitions;
        }
    }
}
