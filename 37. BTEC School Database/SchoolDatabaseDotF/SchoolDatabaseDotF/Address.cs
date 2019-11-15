using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabaseDotF
{
    public class Address
    {
        private String houseNameNumber;
        private String street;
        private String town;
        private String county;
        private String postCode;

        // Now define the class constructor
        // This is called every time an Address is created e.g. new Address()
        public Address(String thehouseNameNumber,
                 String theStreet,
                 String theTown,
                 String theCounty,
                 String thePostCode)
        {
            houseNameNumber = thehouseNameNumber;
            street = theStreet;
            county = theCounty;
            town = theTown;
            postCode = thePostCode;
        }

        // SethouseNameNumber is used to allow user to set the house, name or number
        public void SethouseNameNumber(String theHouseNameNumber)
        {
            houseNameNumber = theHouseNameNumber;
        }

        // SetStreet is used to allow user to set the street
        public void SetStreet(String theStreet)
        {
            street = theStreet;
        }

        // SetTown is used to allow user to set the town
        public void SetTown(String theTown)
        {
            town = theTown;
        }

        // setCounty is used to allow user to set the county
        public void SetCounty(String theCounty)
        {
            county = theCounty;
        }

        // SetPostCode is used to allow user to set the post code
        public void SetPostCode(String thePostCode)
        {
            postCode = thePostCode;
        }

        // GethouseNameNumber is used to allow user to get the house, name or number
        public String GetHouseNameNumber()
        {
            return houseNameNumber;
        }

        // getStreet is used to allow user to get the street
        public String GetStreet()
        {
            return street;
        }

        // GetTown is used to allow user to get the county
        public String GetTown()
        {
            return town;
        }
        // getCounty is used to allow user to get the county
        public String GetCounty()
        {
            return county;
        }

        // getPostCode is used to allow user to get the post code
        public String GetPostCode()
        {
            return postCode;
        }

        // ToString produces a formatted string for an address

        public override String ToString()
        {
            return (houseNameNumber + ", " + street +
                    ", " + town + ", " + county + ", " + postCode + ".");
        }
    }
}
