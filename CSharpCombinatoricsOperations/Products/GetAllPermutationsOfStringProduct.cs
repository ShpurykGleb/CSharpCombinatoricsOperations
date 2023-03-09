using CSharpCombinatoricsOperations.Interfaces;

namespace CSharpCombinatoricsOperations.Products
{
    //Get all permutations of string product
    internal class GetAllPermutationsOfStringProduct : IStringProductPermutation
    {
        //Method, that swap elements
        private string Swap(string a, int i, int j)
        {
            char[] charArray = a.ToCharArray();

            (charArray[j], charArray[i]) = (charArray[i], charArray[j]);
            string s = new string(charArray);

            return s;
        }

        //Method, that gets permutations of string
        private void GetPermutations(string text, int left, int right, ref List<string> permutations)
        {
            if (left == right)
            {
                permutations.Add(text);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    text = Swap(text, left, i);
                    GetPermutations(text, left + 1, right, ref permutations);
                    text = Swap(text, left, i);
                }
            }
        }

        //Method, that returns all of permutations of string
        public List<string> GetAllPermutationsOfString(string text)
        {
            List<string> permutations = new List<string>();

            if (text != null && text.Length != 0)
            {
                int n = text.Length;
                GetPermutations(text, 0, n - 1, ref permutations);
            }

            return permutations;
        }
    }
}
