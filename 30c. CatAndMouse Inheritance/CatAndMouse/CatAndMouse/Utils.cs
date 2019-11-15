using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse
{
    class Utils
    {
        // a really nice little method from Alex Thomas
        // This is beyond the scop of A Level but you can see how it is used inside Move
        public static T constrain<T>(T value, T lowerBound, T upperBound) where T : IComparable
        { //T is a generic that must be able to be compared to other Ts, hence the IComparable
            if (value.CompareTo(upperBound) < 0 && value.CompareTo(lowerBound) > 0)
            { //see c# docs on CompareTo() for details
                // value is less that UpperBound and value is greater than LowerBound
                return value;
            }
            if (value.CompareTo(upperBound) >= 0)
            {
                // value is >= upperBound
                return upperBound;
            }
            // so we return lowerBound
            return lowerBound;
        }

        // If you want to ignore generics, you could do it this way:
        public static int constrains(int value, int lowerBound, int upperBound)
        {
            if (value.CompareTo(upperBound) < 0 && value.CompareTo(lowerBound) > 0)
            { //see c# docs on CompareTo() for details
                // value is less that UpperBound and value is greater than LowerBound
                return value;
            }
            if (value.CompareTo(upperBound) >= 0)
            {
                // value is >= upperBound
                return upperBound;
            }
            // so we return lowerBound
            return lowerBound;
        }
    }
}
