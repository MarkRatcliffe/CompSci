using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GitHubPatch
{
    public partial class Form1 : Form
    {
        private bool passwordsEqual = false;
        private bool pass1set = false;
        private bool pass2set = false;
        private string uid = "";
        private string password = "";
        private string version = "app-2.2.1";
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("You must enter latest GitHub version in lower box" +
                Environment.NewLine +
                "Find latest in C:\\Users\\<your uid>\\AppData\\Local\\GitHubDesktop");

        }

        private void UidTextBox_TextChanged(object sender, EventArgs e)
        { 
            uid = uidTextBox.Text;
            if ((uid != "") & passwordsEqual)
            {
                applyButton.Enabled = true;
            }

        }

        private void PasswordBox1_TextChanged(object sender, EventArgs e)
        {
            pass1set = true;
        }

        private void PasswordTextBox2_TextChanged(object sender, EventArgs e)
        {

            pass2set = true;
            if ((pass1set & pass2set) & (uid != ""))
            {
                applyButton.Enabled = true;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            password = passwordTextBox1.Text;
            String rootLocation = "C:\\Users\\" + uid;
            String location = rootLocation +
                              "\\AppData\\Local\\GitHubDesktop\\" +
                              version +
                              "\\resources\\app\\git\\cmd\\";
            String httpProxyCmd = location + "git.exe config --global http.proxy http://" +  uid + ":" + password + "@172.20.10.10:8080";
            String httpsProxyCmd = location + "git.exe config --global https.proxy https://" + uid + ":" + password + "@172.20.10.10:8080";
            String sslBackEndCmd = location + "git.exe config --global http.sslBackend \"openssl\"";
            String sslCAInfoCmd = location + "git.exe config --global http.sslCAInfo S:\\Computing\\3 Student Access - Read Only\\cacert.pem";
            String sslVerifyCmd = location + "git.exe config --global http.sslVerify false";


            if ((password == passwordTextBox2.Text) & (uid != ""))
            {
                passwordsEqual = true;
                if ((uid != "") & passwordsEqual)
                {
                    //MessageBox.Show("Executing: \n" + httpProxyCmd + "\n" + httpsProxyCmd);

                    MessageBox.Show("Deleting any existing .gitconfig");
                    // we start by removing a .gitconfig if present
                    File.Delete(rootLocation + "\\.gitconfig");

                    MessageBox.Show("About to reconfigure git");
                    ExecuteCommandSync(httpProxyCmd);
                    ExecuteCommandSync(httpsProxyCmd);
                    ExecuteCommandSync(sslBackEndCmd);
                    ExecuteCommandSync(sslCAInfoCmd);
                    ExecuteCommandSync(sslVerifyCmd);
                    MessageBox.Show("Creating new .gitconfig");
                    MessageBox.Show("Changes applied");
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match and have been cleared");
                passwordTextBox1.Text = "";
                passwordTextBox2.Text = "";
                pass1set = false;
                pass2set = false;
                applyButton.Enabled = false;
            }
        }


        // Executes a shell command synchronously.
        //  param name="command" string command
        //  returns string, as output of the command.
        public void ExecuteCommandSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
            }
            catch (Exception objException)
            {
                MessageBox.Show("Uh oh!!!!");
                // Log the exception
            }
        }

        private void versionTextBox_TextChanged(object sender, EventArgs e)
        {
            version = versionTextBox.Text;
        }

    }
}
