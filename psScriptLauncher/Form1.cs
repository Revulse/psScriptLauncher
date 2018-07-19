using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace psScriptLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_defrag_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\r\n\r\n\r\n\r\n");
            textBox1.AppendText("ALL LOGS WILL BE SAVED TO THE FOLLOWING DIRECTORY:");
            textBox1.AppendText("\r\n\r\n");
            textBox1.AppendText("\\\\atrdc2\\scripts\\PowerShell\\logs\\Defrag-Logs\\");
            Process.Start("PowerShell.exe", "\\\\atrdc2\\scripts\\PowerShell\\Desktops-Defrag.ps1");
        }

        private void button_ipconfig_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\r\n\r\n\r\n\r\n");
            textBox1.AppendText("ALL LOGS WILL BE SAVED TO THE FOLLOWING DIRECTORY:");
            textBox1.AppendText("\r\n\r\n");
            textBox1.AppendText("\\\\atrdc2\\scripts\\PowerShell\\logs\\ipconfig-Logs\\");
            Process.Start("PowerShell.exe", "\\\\atrdc2\\scripts\\PowerShell\\Desktops-ipconfig.ps1");
        }

        private void button_SoftwareVersions_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\r\n\r\n\r\n\r\n");
            textBox1.AppendText("ALL LOGS WILL BE SAVED TO THE FOLLOWING DIRECTORY:");
            textBox1.AppendText("\r\n\r\n");
            textBox1.AppendText("\\\\atrdc2\\scripts\\PowerShell\\logs\\Versions-Logs\\");
            Process.Start("PowerShell.exe", "\\\\atrdc2\\scripts\\PowerShell\\Desktops-Versions.ps1");
        }

        private void button_WOL_Click(object sender, EventArgs e)
        {
            Process.Start("PowerShell.exe", "\\\\atrdc2\\scripts\\PowerShell\\Desktops-WOL.ps1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.AppendText("In order to use this application, you must first meet the following requirements:");
            textBox1.AppendText("\r\n\r\n");
            textBox1.AppendText("1. You are using a computer that is a member of our Active Directory.");
            textBox1.AppendText("\r\n");
            textBox1.AppendText("2. You are a domain Admin.");
            textBox1.AppendText("\r\n");
            textBox1.AppendText("3. You are connected to our domain.");
        }
    }
}
