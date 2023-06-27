using System.Collections.Generic;

namespace Collections.Comparer
{
    public class StringComparerWithOutCaseSensitive : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToLower() == y.ToLower();
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }
}