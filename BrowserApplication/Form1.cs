using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowserField.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowserField.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowserField.GoHome();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowserField.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowserField.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowserField.Navigate(AddressBar.Text);
        }
    }
}
