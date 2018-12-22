using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace motadblock
{
    public partial class Form1 : Form
    {
        public string hostsPath = Environment.GetEnvironmentVariable("SYSTEMROOT")+"\\system32\\drivers\\etc\\hosts";
        public string currentHosts = motadblock.Properties.Resources.hostslist; // yes, I know this should be in another file, but this is way too convenient 
        // error codes
        // 1 = can't open hosts
        // 2 = can't write to hosts
        // 3 = can't delete from hosts
        // 4 = error telling status
        public Form1()
        {
            InitializeComponent();
        }
        public void showEnabled() {
            statusText.ForeColor = System.Drawing.Color.Lime;
            statusText.Text = "ENABLED";
        }
        public void showDisabled()
        {
            statusText.ForeColor = System.Drawing.Color.Orange;
            statusText.Text = "DISABLED";
        }
        public void disableButtons()
        {
            enableButton.Enabled = false;
            disableButton.Enabled = false;
        }
        public void showFucked(String error)
        {
            statusText.ForeColor = System.Drawing.Color.Red;
            statusText.Text = "FUCKED - " + error;
            // disableButtons(); // (temporary for debugging)
        }
        public void enableButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Open(hostsPath, FileMode.Append, FileAccess.Write, FileShare.None)) {
                fs.Write(new UTF8Encoding(true).GetBytes(currentHosts), 0, new UTF8Encoding(true).GetBytes(currentHosts).Length);
        }
            setStatus();
        }

        public void disableButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(hostsPath, Regex.Replace(File.ReadAllText(hostsPath), @"(?s)\r\n#motadblock - do not add anything until after #end of motadblock.*#end of motadblock - add things under here", @""));
            setStatus();
        }
        public void setStatus()
        {
            bool enabled = false;
            string[] lines = System.IO.File.ReadAllLines(hostsPath);
            foreach (string line in lines)
            {
                if (line.Contains("motadblock"))
                {
                    enabled = true;
                    break;
                }
            }
            if (enabled)
            {
                showEnabled();
            }
            else
            {
                showDisabled();
            }
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            enableButton.Font = new Font(enableButton.Font.FontFamily, 72);
            disableButton.Font = new Font(disableButton.Font.FontFamily, 72);
            setStatus();
        }
    }
}
