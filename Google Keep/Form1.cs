using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Google_Keep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
//            timer1.Start();
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Google Keep", Application.ExecutablePath.ToString());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            this.Location = new Point(x, 0);
            this.ShowInTaskbar = false;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://keep.google.com");
                webBrowser1.Navigate(queryaddress.ToString());
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
