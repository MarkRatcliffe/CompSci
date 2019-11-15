using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The following classes are required to write data as Serializable objects
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SchoolRecords
{
    [Serializable]  //Set this attribute to all the classes that want to serialize
    public class Person  
    {
        private String firstName = "";
        private String lastName = "";
        private int age = 0;
        private Address livesAt;

        // CONSTRUCTOR - we could use the default ....
        // But it gets long winded to have to set each name and age separately.
        // We can change the constructor appropriately

        public Person(String theFirstName, String theLastName, int anAge)
        {
            firstName = theFirstName;
            lastName = theLastName;
            age = anAge;
        }

        // Constructor which also takes the address
        // Note how I call the one above
        public Person(String theFirstName, String theLastName, int anAge, Address theAddress) :  this(theFirstName, theLastName, anAge)
        {
            livesAt = theAddress;
        }

        // But we might like to keep the DEFAULT CONSTRUCTOR too
        public Person()
        {
            // we dont need to do anything but if we have it, we can call it.
        }

        // setName procedure allows a user to set a Person's firstName
        public void SetFirstName(String theString)
        {
            firstName = theString;
        }

        //GetName function returns a Person's firstName
        public String GetFirstName()
        {
            return firstName;
        }

        // setName procedure allows a user to set a Person's lastName
        public void SetLastName(String theString)
        {
            lastName = theString;
        }

        //GetName function returns a Person's lastName
        public String GetLastName()
        {
            return lastName;
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

        // setAddress procedure allows a user to set a Person's Agdress
        public void SetAddress(Address theAddress)
        {
            livesAt = theAddress;
        }

        //getAddress function returns a Person's address
        public Address GetAddress()
        {
            return livesAt;
        }

        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            return firstName + 
                lastName +
                " is aged " + 
                age + 
                Environment.NewLine + 
                this.GetAddress();
        }

    }
}
