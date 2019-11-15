using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// The following classes are required to write data as Serializable objects
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SchoolRecords
{
    [Serializable]  //Set this attribute to all the classes that want to serialize
    public class School
    {
        // This is the main class which gives access to the Teachers, Students and Subjects
        private Subjects theSubjects;
        private Teachers theTeachers;
        private Students theStudents;
        public static int MaxSubjectsPerPupil = 6;

        //default constructor - doesn't do anything (used when loading an existing school from file) 
        public School()
        {
        }

        // constructor allowing maximum sizes to be set for subjects, teachers and students.
        public School(int maxSubjects, int maxTeachers, int maxStudents)
        {
            theSubjects = new Subjects(maxSubjects);
            theTeachers = new Teachers(maxTeachers);
            theStudents = new SchoolRecords.Students(maxStudents); 
        }

        // getSubjects gives access to the full set of subjects
        public Subjects GetSubjects()
        {
            return theSubjects;
        }

        // GetTeachers gives access to the full set of teachers
        public Teachers GetTeachers()
        {
            return theTeachers;
        }

        // GetSubjects gives access to the full set of students
        public Students GetStudents()
        {
            return theStudents;
        }

        // LoadFromFile loads the entire school from file, given as a parameter
        // returns -1 if unable to find file, in which case School is reset
        public int LoadFromFile(String fileName)
        {
            School tempSchool;
            if (!File.Exists(fileName))
            {
                // if the file doesn't exist return error code -1
                return -1;
            }

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {


                Console.WriteLine("Deserializing vector");
                BinaryFormatter formatter = new BinaryFormatter();
                tempSchool = (School)formatter.Deserialize(fs);
                fs.Close();
                theSubjects = tempSchool.theSubjects;
                theTeachers = tempSchool.theTeachers;
                theStudents = tempSchool.theStudents;
              
                return 0;

            }
            catch (Exception e)
            {
                // we go here in the case of an exception
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        // WriteToFile writes the entire school to file, given as a parameter
        // returns 0 if successful
        public int WriteToFile(String fileName)
        {

            FileStream fs = new FileStream(fileName, FileMode.Create); // creates or overwrites
            try
            {

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
                return 0;
            }
            catch (Exception e)
            {
                // if we got here something went wrong 
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
