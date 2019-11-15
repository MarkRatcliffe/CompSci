using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords
{
    class Student: Person
    {
        // student inherits everything from Person 

        // Student will also have a Director of Studies
        private Teacher DOS;

        //Student also has a collection of Subjects
        private Subjects studies;

        public Student (String aName, int anAge, Teacher theDOS) : base(aName, anAge)
        {
            DOS = theDOS;
        }

        // setDOS procedure allows a user to set a Student's DOS
        public void setDOS(Teacher theDOS)
        {
            DOS = theDOS;
        }

        //getDOS function returns a Student's DOS
        public Teacher getDOS()
        {
            return DOS;
        }

        // setSubjects procedure allows a user to set a Student's Subjects
        public void setSubjects(Subjects theSubjects)
        {
            studies = theSubjects;
        }

        // getSubjects function returns a Student's Subkects
        public Subjects getSubjects()
        {
            return studies;
        }
    }
}
