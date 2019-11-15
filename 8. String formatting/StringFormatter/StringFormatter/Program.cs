using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatter
{
    class Program
    {
        class StringFormatting
        {

            // put your methods in here

            // stringSeparator pads out string with a space between each character
            public String stringSeparator(String stringToProcess)
            {
                String temp = "";
                for (int i = 0; i < stringToProcess.Length; i++)
                {
                    temp = temp + stringToProcess[i] + " ";
                }
                return temp;
            }


            // stringReverse reverses a string
            public String stringReverse(String stringToProcess)
            {
                String temp = "";
                for (int i = stringToProcess.Length - 1; i >= 0; i--)
                {
                    temp = temp + stringToProcess[i];
                }
                return temp;
            }

            // passes back -1 if the strings are of different length
            // passes back 0 if the strings are the same length
            // passes back 1 if the strings are the same length, and are equal
            public int stringCompare(String string1, String string2)
            {
                if (string1.Length != string2.Length)
                {
                    return -1;
                }
                else
                {   if (string1 == string2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            public int sumVowels(String stringToProcess)
            {
                int total = 0;
                // first convert to lower case
                stringToProcess = stringToProcess.ToLower();

                for (int i = 0; i < stringToProcess.Length; i++)
                {
                    if ((stringToProcess[i] == 'a') |
                        (stringToProcess[i] == 'e') |
                        (stringToProcess[i] == 'i') |
                        (stringToProcess[i] == 'o') |
                        (stringToProcess[i] == 'u'))
                        total++;
                }
                return total;
            }

            public int sumConsonants(String stringToProcess)
            {
                int total = 0;
                // first convert to lower case
                stringToProcess = stringToProcess.ToLower();

                for (int i = 0; i < stringToProcess.Length; i++)
                {
                    // check that its an actual letter a to z
                    if ((stringToProcess[i] >= 'a') & (stringToProcess[i] <= 'z') &
                        (stringToProcess[i] != 'a') &
                        (stringToProcess[i] != 'e') &
                        (stringToProcess[i] != 'i') &
                        (stringToProcess[i] != 'o') &
                        (stringToProcess[i] != 'u'))
                        total++;
                }
                return total;
            }

                static void Main(string[] args)
            {
                StringFormatting myFormatter = new StringFormatting();

                // now you can call the methods 

                    
                Console.WriteLine("Enter your string to test");

                String userTest = Console.ReadLine();

                Console.WriteLine("Testing stringSeparator");
                Console.WriteLine("The result was : {0}", myFormatter.stringSeparator(userTest));

                Console.WriteLine("Testing stringReverse");
                Console.WriteLine("The result was : {0}", myFormatter.stringReverse(userTest));

                Console.WriteLine("Enter your second string");
                String userTest2 = Console.ReadLine();

                int result = myFormatter.stringCompare(userTest, userTest2);

                switch (result)
                {
                    case -1:
                        Console.WriteLine("The strings are unequal");
                        break;
                    case 0:
                        Console.WriteLine("The length of both strings are equal");
                        break;
                    case 1:
                        Console.WriteLine("The length of both strings are equal");
                        Console.WriteLine("And also, both strings are equal.");
                        break;
                    default:
                        Console.WriteLine("Something weird happened");
                        break;
                }

                Console.WriteLine("The number of vowels in first string are {0}", myFormatter.sumVowels(userTest));
                Console.WriteLine("The number of consonants in first string are {0}", myFormatter.sumConsonants(userTest));

                // delay disposal of window
                Console.ReadLine();

            }
        }
    }
}
