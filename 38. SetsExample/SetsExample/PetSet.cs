using System;
using System.Collections.Generic;
using System.Text;

namespace SetsExample
{
    public class PetSet
    {
        public enum Pets { Dogs, Cats, Rabbits, Squirrels, Foxes, Hamster, Mice }

        private bool[] theSet = new bool[Enum.GetNames(typeof(Pets)).Length];

        public void Add(Pets thePet)
        {
            theSet[(int)thePet] = true;
        }

        public void Remove(Pets thePet)
        {
            theSet[(int)thePet] = false;
        }

        public bool MemberOf(Pets thePet)
        {
            return theSet[(int)thePet];
        }
    }
}
