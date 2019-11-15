using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneArmedBandit
{
    public class WheelOfFruit
    {
        static Random rand = new Random(); // used for generating random numbers. I only want one!!!!

        // enumerated type of fruits that is available to everyone
        public enum Fruits { Apple, Banana, Bar, Grape, Orange, Pair, Raspberry, Strawberry }

        private Fruits[] theWheel = new Fruits[8];

        const int viewPos = 4; // used to indicate the central fruit on display

        // default constructor 
        public WheelOfFruit()
        {
            // initialise the array with each fruit, Apple to position 0, Banana to 1, etc
            for (int i=0; i < theWheel.Length; i++)
            {
                theWheel[i] = (Fruits)i;
            }
            // call shuffle to shuffle the set of fruits
            this.shuffle();
        }

        // shuffle is used to make sure that not all wheels are the same - the order should be different I think
        private void shuffle()
        {
            int first, second;          // we are going to repeatedly swap first and second

            Fruits temp;                // our temporary location for swap- try swapping two melons with just two hands!!
             
            // to shuffle, we are just going to generate some random numbers and swap the fruits between first and second
            for (first = 0; first < theWheel.Length; first++)
            {
                second = rand.Next(0, theWheel.Length);  // get a random value within range

                // Now swap
                temp = theWheel[first];
                theWheel[first] = theWheel[second];
                theWheel[second] = temp;
            
            }
        }

        // spin is used to spin the wheel so many notches (Wheel.Length notches represents a complete rotation)
        public void spin(int num)
        {
            Fruits front; // used to store the Fruit at the front which will go to the back

            for (int notch = 0; notch < num; notch++)
            {
                // each notch represents a single shunt down the array. moving front to back
                front = theWheel[0];
                for (int i = 0; i < theWheel.Length-1; i++)
                {
                    theWheel[i] = theWheel[i + 1];
                }
                theWheel[theWheel.Length - 1] = front;
            }
        }

        public Fruits getCurrentFruit()
        {
            return theWheel[viewPos];  // returns the fruit at viewpoint
        }

    }

}
