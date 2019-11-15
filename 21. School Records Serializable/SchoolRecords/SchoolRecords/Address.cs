using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords
{
    [Serializable]  //Set this attribute to all the classes that want to serialize
    public class Address
    {
        private String houseNameNumber;
        private String street;
        private String county;
        private String postCode;

        // Now define the class constructor
        // This is called every time an Address is created e.g. new Address()
        public Address(String thehouseNameNumber,
                 String theStreet,
                 String theCounty,
                 String thePostCode)
        {
            houseNameNumber = thehouseNameNumber;
            street = theStreet;
            county = theCounty;
            postCode = thePostCode;
        }

        // SetHouseNameOrNumber is used to allow user to set the house, name or number
        public void SetHouseNameOrNumber(String theHouseNameNumber)
        {
            houseNameNumber = theHouseNameNumber;
        }

        // SetStreet is used to allow user to set the street
        public void SetStreet(String theStreet)
        {
            street = theStreet;
        }

        // SetCounty is used to allow user to set the county
        public void SetCounty(String theCounty)
        {
            county = theCounty;
        }

        // SetPostCode is used to allow user to set the post code
        public void SetPostCode(String thePostCode)
        {
            postCode = thePostCode;
        }

        // gethouseNameNumber is used to allow user to get the house, name or number
        public String GetHouseNameOrNumber()
        {
            return houseNameNumber;
        }

        // GetStreet is used to allow user to get the street
        public String GetStreet()
        {
            return street;
        }

        // GetCounty is used to allow user to get the county
        public String GetCounty()
        {
            return county;
        }

        // GetPostCode is used to allow user to get the post code
        public String GetPostCode()
        {
            return postCode;
        }

        // ToString produces a formatted string for an address

        public override String ToString()
        {
            return (houseNameNumber + ", " + street +
                    ", " + county + ", " + postCode + ".");
        }
    }
}
