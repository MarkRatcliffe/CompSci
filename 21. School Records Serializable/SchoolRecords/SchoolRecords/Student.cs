using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords
{
    [Serializable]  //Set this attribute to all the classes that want to serialize
    public class Student: Person
    {
        // student inherits everything from Person 

        // Student will also have a Director of Studies
        private Teacher DOS;

        //Student also has a collection of Subjects
        private Subjects studies;

        public Student(String aFirstName, String aLastName, int anAge, Address theAddress) : base(aFirstName, aLastName, anAge, theAddress)
        {
        }

        public Student (String aFirstName, String aLastName, int anAge, Teacher theDOS) : base(aFirstName, aLastName, anAge)
        {
            DOS = theDOS;
        }

        // SetDOS procedure allows a user to set a Student's DOS
        public void SetDOS(Teacher theDOS)
        {
            DOS = theDOS;
        }

        //GetDOS function returns a Student's DOS
        public Teacher GetDOS()
        {
            return DOS;
        }

        // SetSubjects procedure allows a user to set a Student's Subjects
        public void SetSubjects(Subjects theSubjects)
        {
            studies = theSubjects;
        }

        // GetSubjects function returns a Student's Subkects
        public Subjects GetSubjects()
        {
            return studies;
        }
    }
}
