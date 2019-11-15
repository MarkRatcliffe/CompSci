using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                // You need this for file handling
using MyMusic.Properties;   // You need this to access your Resources

namespace MyMusic
{
    public class MusicCollection
    {
        // tracks is an array that can hold all the tracks in the collection
        private Track[] tracks;

        // nextFreeLocation keeps track of how many, and where to insert next track into collection
        private int nextFreeLocation;

        // name of collection - used to name the external file
        private String name;

        // constructor takes a single parameter which specifies maximum size
        public MusicCollection(int theSize, String theName)
        {
            name = theName;
            tracks = new Track[theSize];
        }

        // ReadFromFile reads from a user file that is passed as a parameter
        public bool ReadFromFile(String filename)
        {
            Track temp;
            // check that file exists
            if (!File.Exists(filename))
                return false;

            nextFreeLocation = 0; // we do this to clear any previous entries

            StreamReader reader = new StreamReader(filename);

            // read in the strings and store in my tracksarray
            String line;
            while ((line = reader.ReadLine()) != null)
            {
                // each time round the loop, I **must** create a new Track
                temp = new Track(line, reader.ReadLine());
                // now add track into collection
                tracks[nextFreeLocation] = temp;
                nextFreeLocation++;
            }
            reader.Close();   // dont forget to close the file!!
            // if I get here (without throwing any exceptions), return true
            return true;
        }

        // Note how I am overloading ReadFromFile when no parameters are given
        // When called without a file, we are reading in from the resources ie the master music file
        // NOTE that this CANNOT be written to 
        public bool ReadFromFile()
        {
            Track temp;
            StringReader reader = new StringReader(Resources.music);
            nextFreeLocation = 0; // we do this to clear any previous entries

            // read in the strings and store in my tracksarray
            String line;
            while ((line = reader.ReadLine()) != null)
            {
                // each time round the loop, I **must** create a new Track
                temp = new Track(line, reader.ReadLine());
                // now add track into collection
                tracks[nextFreeLocation] = temp;
                nextFreeLocation++;
            }
            reader.Close();   // dont forget to close the file!!
            return true;
        }


        // WriteToFile writes to a user file that is passed as a parameter
        // NOTE there is no equivalent implemented for saving the resource file
        // This is not possible as it is part of the compiled executable.
        public bool WriteToFile(String filename)
        {
            StreamWriter writer = new StreamWriter(filename);

            // iterate over array and write out to file
            for (int i = 0; i < nextFreeLocation; i++)
            {
                writer.WriteLine(tracks[i].GetTitle());
                writer.WriteLine(tracks[i].GetArtist());
            }
            writer.Close();   // dont forget to close the file!!
            // if I get here (without throwing any exceptions), return true
            return true;
        }


        // method to add a Track to the collection
        public bool addTrack(Track theTrack)
        {
            // check that there is room in the array
            if (nextFreeLocation >= tracks.Length)
                return false;
            tracks[nextFreeLocation] = theTrack;
            nextFreeLocation++;
            return true;
        }
        // method to search on title, and artist, then if found return a single track
        public Track search(String theTitle, String theArtist)
        {
            for (int i = 0; i < nextFreeLocation; i++)
            {
                if ((tracks[i].GetTitle() == theTitle) &
                        (tracks[i].GetArtist() == theArtist))
                    return tracks[i];
            }
            // if we got here, then it wasnt found
            return (Track)null;
        }

        // size passes back the number of tracks in the list
        public int Size()
        {
            return nextFreeLocation;
        }

        // GetTrackByPosition passes back the tracks in required position
        // null is returned if value is out of range
        public Track GetTrackByPosition(int num)
        {
            if ((num >= 0) & (num <= nextFreeLocation))
                return tracks[num];
            else
                return (Track)null;
        }

        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            String libraryString = "";
            for (int i = 0; i < nextFreeLocation; i++)
            {
                libraryString = libraryString +
                    tracks[i].GetTitle() +
                    " by " +
                    tracks[i].GetArtist() +
                    Environment.NewLine;
            }
            return libraryString;
        }
    }
}
