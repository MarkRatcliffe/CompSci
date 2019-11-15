using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingII
{
    class InsertionSort
    {
        public void InsertSort(ref int[] aList)
        {
            int nextItem, i;
            // We're using zero based so j starts at 1 but i will start from 0 
            // We assume that the item at location zero is already sorted so we go from there
            for (int j=1; j < aList.Length; j++)
            {
                // save current item which is further along our "tested" area
                nextItem = aList[j];
                i = j - 1;

                // now we move back through sorted area, shunting any 'greater than' along if necessary
                while ((i >= 0) && aList[i] > nextItem)
                {
                    aList[i + 1] = aList[i];
                    i = i - 1;
                }
                aList[i + 1] = nextItem; // now insert at correct position
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
