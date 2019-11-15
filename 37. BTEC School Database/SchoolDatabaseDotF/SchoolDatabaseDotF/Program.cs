using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabaseDotF
{
    class Program
    {
        static void Main(string[] args)
        {
            Address fredsHouse = new Address("1", "Long Lane", "Colwall", "Herefordshire", "HR6 1FG");
            Person fred = new Student("Fred Smith", 18, fredsHouse,"0124352");
            Person bill = new Student("Bill Smith", 16, fredsHouse, "0124655");
            Console.WriteLine(fred);
            Console.WriteLine(bill);
            Console.ReadLine();
        }
    }
}
