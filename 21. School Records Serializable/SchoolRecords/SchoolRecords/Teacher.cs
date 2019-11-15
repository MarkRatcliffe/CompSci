using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords
{
    [Serializable]  //Set this attribute to all the classes that want to serialize
    public class Teacher:Person   // "Teacher inherits Person"  or "Teacher extends Person"
    {
        private Subjects teaches;
        
        public Teacher(String firstName, String lastName, int anAge): base(firstName, lastName, anAge)
        {
            // initialise to an empty collection of subjects
            // assume that no teacher can teach more than the number of subjects a student can ytake e.g. 6
            teaches = new Subjects(6);
        }

        public override string ToString()
        {
            String temp = base.ToString();
            temp = temp + "Teaches:" + Environment.NewLine;
            temp = temp + teaches.ToString();
            return temp;
        }
    }
}
