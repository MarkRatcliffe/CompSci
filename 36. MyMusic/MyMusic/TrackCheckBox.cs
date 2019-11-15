using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusic
{
    class TrackCheckBox:CheckBox
    {
        private Track associatedTrack;

        public TrackCheckBox (Track theTrack):base()
        {
            associatedTrack = theTrack;
        }

        // getTrack enables user to get the Track associated with the CheckBox
        public Track getTrack()
        {
            return associatedTrack;
        }
    }
}
