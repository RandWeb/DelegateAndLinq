using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Comparer
{
    public class EducationComparer:IEqualityComparer<Education>
    {
        public bool Equals(Education x, Education y)
        {
            return x?.Title == y?.Title;
        }

        public int GetHashCode(Education obj)
        {
            return obj.GetHashCode();
        }
    }
}
