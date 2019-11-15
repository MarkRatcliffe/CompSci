using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUI
{
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

        // sethouseNameNumber is used to allow user to set the house, name or number
        public void sethouseNameNumber(String theHouseNameNumber)
        {
            houseNameNumber = theHouseNameNumber;
        }

        // setStreet is used to allow user to set the street
        public void setStreet(String theStreet)
        {
            street = theStreet;
        }

        // setCounty is used to allow user to set the county
        public void setCounty(String theCounty)
        {
            county = theCounty;
        }

        // setPostCode is used to allow user to set the post code
        public void setPostCode(String thePostCode)
        {
            postCode = thePostCode;
        }

        // gethouseNameNumber is used to allow user to get the house, name or number
        public String getHouseNameNumber()
        {
            return houseNameNumber;
        }

        // getStreet is used to allow user to get the street
        public String getStreet()
        {
            return street;
        }

        // getCounty is used to allow user to get the county
        public String getCounty()
        {
            return county;
        }

        // getPostCode is used to allow user to get the post code
        public String getPostCode()
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
