using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptian
{
    public class Encryptor
    {
        public String encrypt(String inputString, int shift)
        {
            String outputString = "";
            char currentChar = ' ';

            // first convert to upper case
            inputString = inputString.ToUpper();

            // lets move along the string adding shift to each character
            for (int i=0; i < inputString.Length; i++)
            {
                currentChar = (char) (inputString[i] + shift);

                // But if we have gone past 'Z' we need, to take off 26 to get back round to A

                if (currentChar > 'Z')
                {
                    currentChar = (char)(currentChar - 26);
                }

                // But if we have gone below 'A' we need, to add 26 to get back to Z

                if (currentChar < 'A')
                {
                    currentChar = (char)(currentChar + 26);
                }

                outputString = outputString + currentChar;
            }
            return outputString;
        }

        public String decrypt(String inputString, int shift)
        {
            return this.encrypt(inputString, -(shift));
        }
    }
}
