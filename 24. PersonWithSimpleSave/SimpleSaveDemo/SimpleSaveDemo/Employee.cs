using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleSaveDemo
{
    public class Employee : Person
    {
        private String payrollNum;

        // Constructor needs to call parent constructor with Name and Age
        public Employee(String aName, int anAge, String thePayrollNum) : base(aName, anAge)
        {
            payrollNum = thePayrollNum;
        }

        // Provide default constructor in case it's required
        public Employee()
        {

        }


        // SetName procedure allows a user to set an Employee's payroll number
        public void SetPayroll(String thePayNum)
        {
            payrollNum = thePayNum;
        }


        //GetPayroll function returns an Employee's payroll number
        public String GetPayroll()
        {
            return payrollNum;
        }


        // readFromStream reads in an Employee from a file
        public new Employee ReadFromStream(StreamReader theStream)
        {
            // I could use Base.ReadFromStream but it's just as quick to rewrite
            return new Employee(theStream.ReadLine(), Convert.ToInt32(theStream.ReadLine()), theStream.ReadLine());
        }

        // writeToStream - note specific use of new to confoirm I'm overriding parent method
        public new void WriteToStream(StreamWriter theStream)
        {
            // let's use the base class WriteToStream, then add the payroll on a new line
            base.WriteToStream(theStream);
            theStream.WriteLine(this.GetPayroll());
        }

        //ToString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            return base.ToString() + "Employee Num" + payrollNum;
        }
    }
}
