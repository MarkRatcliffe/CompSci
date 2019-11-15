using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusic
{
    public partial class Form1 : Form
    {
        MusicCollection mainCollection = new MusicCollection(100, "Main");
        MusicCollection userCollection = new MusicCollection(10, "Main");
        TrackCheckBox[] masterCB; // the checkboxes for the Master collection
        public Form1()
        {
            mainCollection.ReadFromFile();  // read in the master music list
            InitializeComponent();
            createCheckBox(masterPanel, mainCollection);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            userCollectionTextBox.Text = ""; // reset textbox contents
            for (int i = 0; i < masterCB.Length; i++)
            {
                if (masterCB[i].Checked)
                {
                    // we add the selected track to our user's collection
                    userCollection.addTrack(masterCB[i].getTrack());
                    userCollectionTextBox.Text =
                        userCollectionTextBox.Text + masterCB[i].getTrack();
                }
            }
        }

        private void createCheckBox(Panel thePanel, MusicCollection tracks )
        {
            Point newLoc = new Point(5, 5); // Set whatever you want for initial location
            masterCB = new TrackCheckBox[tracks.Size()];
            String displayName;
            for (int i=0; i < masterCB.Length; i++)
            {
                // I add the Track so I can get it back later
                masterCB[i] = new TrackCheckBox(tracks.GetTrackByPosition(i));
                masterCB[i].Size = new Size(180, 30);
                masterCB[i].Location = newLoc;
                newLoc.Offset(0, masterCB[i].Height + 2);
                
                displayName = tracks.GetTrackByPosition(i).GetTitle() +
                              " -- " +
                              tracks.GetTrackByPosition(i).GetArtist();
                masterCB[i].Text = displayName;
                thePanel.Controls.Add(masterCB[i]);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            userCollection.WriteToFile(nameBox.Text);
            MessageBox.Show("Have saved your list in " +
                             nameBox.Text +
                             " in bin/Debug");

        }
    }
}
