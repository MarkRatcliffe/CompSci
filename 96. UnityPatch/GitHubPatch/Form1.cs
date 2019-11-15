using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace UnityPatch
{
    public partial class Form1 : Form
    {
        private bool passwordsEqual = false;
        private bool pass1set = false;
        private bool pass2set = false;
        private string uid = "";
        private string password = "";

        public Form1()
        {
            InitializeComponent();
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

            String httpProxyCmd = "[System.Environment]::SetEnvironmentVariable('HTTP_proxy', 'http://" + uid + ":" + password + "@172.20.10.10:8080',[System.EnvironmentVariableTarget]::User)";
            String httpsProxyCmd = "[System.Environment]::SetEnvironmentVariable('HTTPS_proxy', 'https://" + uid + ":" + password + "@172.20.10.10:8080',[System.EnvironmentVariableTarget]::User)";

            if ((password == passwordTextBox2.Text) & (uid != ""))
            {
                passwordsEqual = true;
                if ((uid != "") & passwordsEqual)
                {
                    MessageBox.Show("Executing: \n" + httpProxyCmd + "\n" + httpsProxyCmd);
                    String result1 = RunScript(httpProxyCmd);
                    String result2 = RunScript(httpsProxyCmd);
                    MessageBox.Show(result1 + result2);
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

        private string RunScript(string scriptText)
        {
            // create Powershell runspace

            Runspace runspace = RunspaceFactory.CreateRunspace();

            // open it

            runspace.Open();

            // create a pipeline and feed it the script text

            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(scriptText);

            // add an extra command to transform the script
            // output objects into nicely formatted strings

            // remove this line to get the actual objects
            // that the script returns. For example, the script

            // "Get-Process" returns a collection
            // of System.Diagnostics.Process instances.

            pipeline.Commands.Add("Out-String");

            // execute the script

            Collection <PSObject> results = pipeline.Invoke();

            // close the runspace

            runspace.Close();

            // convert the script result into a single string

            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }

            return stringBuilder.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
