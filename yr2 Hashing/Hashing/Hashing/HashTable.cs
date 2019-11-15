using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    abstract public class Hashable
    {
        abstract public int getHash();
        override abstract public bool Equals(object obj);
    }

    class HashTable
    {
        private int tableSize = 10; // initial value

        private class Entries
        {
            private bool deleted = false;
            private Hashable theKey;
            private Object theData;

            public Entries()
            {
                theKey = null;
                theData = null;
            }

            public Entries(Hashable aKey, Object someData)
            {
                theKey = aKey;
                theData = someData;
            }

            public void setDeleted(bool theFlag)
            {
                deleted = theFlag;
            }

            public bool isDeleted()
            {
                return deleted;
            }

            public void setKey(Hashable aKey)
            {
                theKey = aKey;
            }

            public Hashable getKey()
            {
                return theKey;
            }

            public void setData(Object aData)
            {
                theData = aData;
            }

            public Object getData()
            {
                return theData;
            }

            public override String ToString()
            {
                String temp = "";
                if (deleted)
                    temp = "D";
                else
                    temp = "_";
                if (theKey != null)
                {
                    temp = temp + theKey.ToString() + " " + theData.ToString();
                }
                return temp;
            }


        }


        private Entries[] theTable;
        public HashTable(int theSize)
        {
            // you could determine the next prime number above theSize and use that
            tableSize = theSize;
            theTable = new Entries[tableSize];
            for (int i = 0; i < tableSize; i++)
            {
                theTable[i] = new Entries();
            }
        }

        // find key by hashing then probing until key or an empty space is found
        private int findKey(Hashable theItem)
        {
            int locationToUse;

            // call has function and ensure it is within range of table
            locationToUse = theItem.getHash() % tableSize;
            // now we do a probe, looking for next empty space 
            while ( !(theTable[locationToUse].isDeleted()) & 
                     (theTable[locationToUse].getKey() != null ) &&
                    !(theTable[locationToUse].getKey().Equals(theItem))) 
            {
                Console.WriteLine("moving on");
                locationToUse = (locationToUse + 1) % tableSize;
            }
            if ((theTable[locationToUse].getKey() != null) &&
                (theTable[locationToUse].getKey().Equals(theItem)))
                return locationToUse;
            else
                return -1;
        }

        public bool addToTable(Hashable theItem, Object theData)
        {
            int locationToUse;

            // call has function and ensure it is within range of table
            locationToUse = theItem.getHash() % tableSize;
            // now we do a probe, looking for next empty space 
            while ((theTable[locationToUse].getKey() != null) &
                    !theTable[locationToUse].isDeleted())
            {
                locationToUse = (locationToUse + 1) % tableSize;
            }
            theTable[locationToUse] = new Entries(theItem, theData);
            return true;
        }

        public Object removeFromTable(Hashable theItem)
        {
            int locationToUse = findKey(theItem);
            Object temp;
            if (locationToUse == -1) // could not find key
                return (Object)null;
            else
            {
                temp = theTable[locationToUse].getData();
                theTable[locationToUse].setDeleted(true);
                theTable[locationToUse].setKey(null);
                theTable[locationToUse].setData(null);
                return temp;
            }

            // now we do a probe, looking for key 

        }

        public override String ToString()
        {
            String temp = "";
            for (int i = 0; i < tableSize - 1; i++)
            {
                temp = temp + i + " " + theTable[i].ToString() + Environment.NewLine;
            }
            return temp;
        }


    }
}
