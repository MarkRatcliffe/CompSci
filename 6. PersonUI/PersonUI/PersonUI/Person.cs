using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUI
{
    public class Person
    {
        private String name = "";

        private int age = 0;

        // CONSTRUCTOR - we could use the default ....
        // But it gets long winded to have to set each name and age separately.
        // We can change the constructor appropriately

        public Person(String aName, int anAge)
        {
            this.setName(aName);
            this.setAge(anAge);
        }

        // But we might like to keep the DEFAULT CONSTRUCTOR too
        public Person()
        {
             // we dont need to do anything but if we have it, we can call it.
        }

        // setName procedure allows a user to set a Person's name
        public void setName(String theString)
        {
            name = theString;
        }

        //getName function returns a Person's name
        public String getName()
        {
            return name;
        }

        // setAge procedure allows a user to set a Person's age
        public void setAge(int theAge)
        {
            age = theAge;
        }

        //getAge function returns a Person's age
        public int getAge()
        {
            return age;
        }

        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            return this.getName() + " is aged " + this.getAge();
        }

    }
}
