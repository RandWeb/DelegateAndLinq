using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Comparer
{
    public class MotorCompanyAndTypeComparer:IEqualityComparer<Motor>
    {
        public bool Equals(Motor x, Motor y)
        {
            return x.MotorType == y.MotorType;
        }

        public int GetHashCode(Motor obj)
        {
            return obj.Company.GetHashCode();
        }
    }

    public class MotorTypeComparer : IEqualityComparer<Motor>
    {
        public bool Equals(Motor x, Motor y)
        {
            return true;
        }

        public int GetHashCode(Motor obj)
        {
            return obj.MotorType.GetHashCode();
        }
    }

    public class MotorTypeAndNameComparer : IEqualityComparer<Motor>
    {
        public bool Equals(Motor x, Motor y)
        {
            return x.MotorName == y.MotorName;
        }

        public int GetHashCode(Motor obj)
        {
            return obj.MotorType.GetHashCode();
        }
    }

}
