using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Wilma Jones", 60);
            Console.WriteLine("The name is " + p1.GetName());
            Console.WriteLine("The age is " + p1.GetAge());
            Console.WriteLine("What would you like the name to be set to?");
            p1.SetName(Console.ReadLine());
            Console.WriteLine("What would you like the age to be set to?");
            p1.SetAge(Convert.ToInt32(Console.ReadLine()));

            Address a1 = new Address("HSFC","Foley Lane", "Hereford", "HR1 1LR");
            p1.SetLivesAt(a1);

            Console.WriteLine(p1);
            Console.ReadLine();
        }
    }
}
