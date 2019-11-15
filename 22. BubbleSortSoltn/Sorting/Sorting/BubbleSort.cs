using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        public void StandardBubbleSort(ref int[] aList)
        {
            bool swapMade = true;
            int temp = 0;
            while (swapMade == true)
            {
                swapMade = false;
                for (int position = 0; position <= aList.Length - 2; position++)
                {
                    if (aList[position] > aList[position + 1])
                    {
                        temp = aList[position];
                        aList[position] = aList[position + 1];
                        aList[position + 1] = temp;
                        swapMade = true;
                    }
                }
            }
        }

        public void ShortBubbleSort(ref int[] aList)
        {
            bool swapMade = true;
            int passnum = aList.Length - 1;
            int temp = 0;
            while (passnum > 0 && swapMade == true)
            {
                swapMade = false;
                for (int position = 0; position <= passnum - 1; position++)
                {
                    if (aList[position] > aList[position + 1])
                    {
                        temp = aList[position];
                        aList[position] = aList[position + 1];
                        aList[position + 1] = temp;
                        swapMade = true;
                    }
                }
                passnum = passnum - 1;
            }
        }

        public void DisplayList(int[] aList)
        {
            Console.Write("Output of list: ");
            for (int i = 0; i <= aList.Length - 1; i++)
            {
                Console.Write(aList[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
