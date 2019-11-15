using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic
{
    public class Track
    {
        private String title;
        private String artist;

        // constructor takes in a title and an artist
        public Track(String theTitle, String theArtist)
        {
            title = theTitle;
            artist = theArtist;
        }

        // setTitle allows a user to set the title
        public void SetTitle(String theTitle)
        {
            title = theTitle;
        }

        // setArtist allows a user to set the artist
        public void SetArtist(String theArtist)
        {
            artist = theArtist;
        }

        // getTitle returns the title of the Track
        public String GetTitle()
        {
            return title;
        }

        // getArtist returns the name of the Artist
        public String GetArtist()
        {
            return artist;
        }

        //toString is a standard method that we use to display (write out) an object
        public override String ToString()
        {
            return this.GetTitle() +
                " -- " +
                this.GetArtist() +
                Environment.NewLine;
        }
    }
}
