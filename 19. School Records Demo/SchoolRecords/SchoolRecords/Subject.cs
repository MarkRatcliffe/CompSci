using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords
{
    public class Subject
    {
        private String name;
        private String level;

        // Now define the class constructor
        // This is called every time a Subject is created e.g. new Subject("Geography","A Level")
        public Subject(String theName, String theLevel)
        {
            // now we can set the required Subject-specific attributes
            name = theName;
            level = theLevel;
        }

        // setName allows a user to set a Subject name
        // String parameter theName defines the name to be set to  e.g. mySub.setName("Astronomy") 
        public void setName(String theName)
        {
            name = theName;
        }

        // setLevel allows a user to set a Subject level
        // String parameter theLevel defines the name to be set to   e.g. mySub.setLevel("A Level")    
        public void setLevel(String theLevel)
        {
            level = theLevel;
        }

        // getLevel allows a user to obtain a Subject level  e.g.  Console.WriteLine(mySub.getLevel())
        public String getName()
        {
            return name;
        }

        public String getLevel()
        {
            return level;
        }

        //redefine the ToString which defines how a Subject will be displayed
        public override String ToString()
        {
            return (name + " " + level);
        }

    }
}
