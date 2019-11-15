using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleSaveDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Employee Name");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Employee Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Payroll Num");
            String payNum = Console.ReadLine();

            Employee e1 = new Employee(name, age, payNum);

            Console.WriteLine("Enter name of file to write Employee to");
            String fileName = Console.ReadLine();


            Console.WriteLine("Opening file");
            StreamWriter theOutputStream = new StreamWriter(fileName);


            Console.WriteLine("Writing employee file");
            e1.WriteToStream(theOutputStream);

            theOutputStream.Close();

            // Now let's test the Load method
            StreamReader theInputStream = new StreamReader(fileName);

            e1 = e1.ReadFromStream(theInputStream);

            Console.WriteLine("Have just read in the following details");

            Console.WriteLine(e1);

            theInputStream.Close();

            Console.ReadLine();
        }
    }
}
