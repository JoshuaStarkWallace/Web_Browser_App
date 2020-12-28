using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //If the enter key is pressed
            {
                webBrowser1.Navigate(AddressBar.Text); //Then the browser will navigate to the address
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AddressBar.Text);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.Google.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "Web Browser - " + webBrowser1.Document.Title;
        }
    }
}
