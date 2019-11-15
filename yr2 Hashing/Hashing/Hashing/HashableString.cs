using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class HashableString: Hashable
    {
        private String theString;

        public HashableString(String aString)
        {
            theString = aString;
        }

        public override int getHash()
        {
            int theKey = 0;
            // this is a place holder and needs to be extended
            for (int i = 0; i < theString.Length-1; i++)
            {
                // I raise to the power of 1,2,3,1,2,3 etc
                theKey = theKey + Convert.ToInt32(Math.Pow(Convert.ToInt32(theString[i]), i%4));
            }
            return theKey;
        }

        public override bool Equals(object obj)
        {
            return (0 == String.Compare(theString, obj.ToString(), false));
        }

        public override String ToString()
        {
            return theString;
        }

    }
}
