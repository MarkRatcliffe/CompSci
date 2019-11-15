using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabaseDotF
{
    public class Person
    {
        private String name = "";
        private int age = 0;
        private Address livesAt;

        // CONSTRUCTOR - we could use the default ....
        // But it gets long winded to have to set each name and age separately.
        // We can change the constructor appropriately

        public Person(String aName, int anAge)
        {
            name = aName;
            age = anAge;
        }

        // But we might like to keep the DEFAULT CONSTRUCTOR too
        public Person()
        {
            // we dont need to do anything but if we have it, we can call it.
        }

        // setName procedure allows a user to set a Person's name
        public void SetName(String theString)
        {
            name = theString;
        }

        //GetName function returns a Person's name
        public String GetName()
        {
            return name;
        }

        // SetAge procedure allows a user to set a Person's age
        public void SetAge(int theAge)
        {
            age = theAge;
        }

        //GetAge function returns a Person's age
        public int GetAge()
        {
            return age;
        }

        // SetLivesAt procedure allows a user to set a Person's Agdress
        public void SetLivesAt(Address theAddress)
        {
            livesAt = theAddress;
        }

        //GetLivesAt function returns a Person's address
        public Address GetLivesAt()
        {
            return livesAt;
        }

        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            return this.GetName() +
                " is aged " +
                this.GetAge() +
                Environment.NewLine +
                this.GetLivesAt();
        }

    }
}
