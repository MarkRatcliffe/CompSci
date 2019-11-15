using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic
{
    public class Student
    {
        private String name = "";
        private int age = 0;
        private MusicCollection myMusic;

        // CONSTRUCTOR - we could use the default ....
        // But it gets long winded to have to set each name and age separately.
        // We can change the constructor appropriately

        public Student(String aName, int anAge)
        {
            this.setName(aName);
            this.setAge(anAge);
            // create a music collection that is 40 long and is named after the student
            myMusic = new MusicCollection(40, aName + "music");
        }

        // But we might like to keep the DEFAULT CONSTRUCTOR too
        public Student() : this("Unassigned", 0)
        {
            // note that this is actually just calling the other constructor
        }

        // setName procedure allows a user to set a Student's name
        public void setName(String theString)
        {
            name = theString;
        }

        //getName function returns a Student's name
        public String getName()
        {
            return name;
        }

        // setAge procedure allows a user to set a Student's age
        public void setAge(int theAge)
        {
            age = theAge;
        }

        //getAge function returns a Student's age
        public int getAge()
        {
            return age;
        }


        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            return this.getName() +
                " is aged " +
                this.getAge() +
                Environment.NewLine +
                this.myMusic;
        }
    }
}
