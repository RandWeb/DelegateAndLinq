using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Comparer
{
    public class StringLengthComparer:IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length - y.Length;

        }
    }
}
