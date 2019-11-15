using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabaseDotF
{
    public class Student: Person
    {
        // every student will have a student number
        private String studentNum = "";

        public Student(String theName,
                       int theAge,
                       Address anAddress,
                       String theNum):base(theName, theAge)
        {
            SetLivesAt(anAddress);
            studentNum = theNum;
        }

        // SetStudentNum is used to allow user to set the student num
        public void SetStudentNum(String num)
        {
            studentNum = num;
        }

        // GetStudentNum is used to allow user to get the student num
        public String GetStudentNum()
        {
            return studentNum;
        }

        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            return base.ToString() +
                Environment.NewLine +
                "Num = " + studentNum +
                Environment.NewLine;
        }
    }
}
