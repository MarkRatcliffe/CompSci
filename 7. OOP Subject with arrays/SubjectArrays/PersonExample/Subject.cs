using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExample
{
    public class Subject
    {
        private String name;

        private Person teacher;

        private int maxNumOfStudents;

        private int currentNumOfStudents;

        //And now the interesting bit

        private Person[] theStudents;
        

        // Constructor allows a user to specify name, teacher and max num of students
        public Subject(String aName, Person aTeacher, int maxNumOfStudents)
        {
            this.name = aName;
            this.teacher = aTeacher;
            this.maxNumOfStudents = maxNumOfStudents;
            theStudents = new Person[maxNumOfStudents];
        }

        // I'm not going to provide default constructor as you need a name and a teacher

        // Now provide sets and gets
        // setName procedure allows a user to set a Person's name
        public void setName(String theString)
        {
            name = theString;
        }

        //getName function returns a Person's name
        public String getName()
        {
            return name;
        }

        // setName procedure allows a user to set a Teacher
        public void setTeacher(Person theTeacher)
        {
            teacher = theTeacher;
        }

        //getName function returns the Teacher
        public Person getTeacher()
        {
            return teacher;
        }

        // setMaxNumOfStudents procedure allows a user to set the max num of students
        // Not allowed - as wont allow a user to change after creation
        /*
        public void setMaxNumOfStudents(int theMaxNumOfStudents)
        {
            maxNumOfStudents = theMaxNumOfStudents;
        }
        */

        //getMaxNumOfStudents function returns the current max num of students
        public int getMaxNumOfStudents()
        {
            return maxNumOfStudents;
        }

        //getCurrentNumOfStudents function returns the current num of students
        public int getCurrentNumOfStudents()
        {
            return currentNumOfStudents;
        }

        //addAStudent adds a Person onto the Subject. 
        // If it fails to add, then it will return False, esle returns True
        public bool addAStudent(Person theStudent)
        {
            if (currentNumOfStudents < maxNumOfStudents)
            {      
                theStudents[currentNumOfStudents] = theStudent;
                // add 1 to the currentNumOfStudents
                currentNumOfStudents++;
                return true;
            }
            // if we get here, then there is no space; we cannot add the student
            return false;
        }

        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            String myStudents = "";
            // we will first build up a string containing the list of students 
            for (int i = 0; i < currentNumOfStudents; i++)
                myStudents = myStudents + theStudents[i].getName() + "\n";
         
            return this.name + " is taught by " 
                               + this.teacher.getName()
                               +".\n It can only have " + this.maxNumOfStudents + " students"
                               + "\n Those registered are \n" +
                               myStudents;
        }
    }
}
