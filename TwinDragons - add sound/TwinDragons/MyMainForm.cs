using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;//must add this library system to make the sound work
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinDragons
{
    public partial class MyMainForm : Form
    {
        public MyMainForm()
        {
            InitializeComponent();
            //this code below set the main page is google
            textBoxURL.Text = "google.com";
            //this code navogate t the URL that is in our URL textbox
            webBrowserDisplay.Navigate(textBoxURL.Text);
            //this will stop JavaScript error from displaying
            webBrowserDisplay.ScriptErrorsSuppressed = true;
        }
        /// <summary>
        /// this will run when the user click the run button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            //this code navogate t the URL that is in our URL textbox
            webBrowserDisplay.Navigate("http://www." + textBoxURL.Text + ".com");
            //this will stop JavaScript error from displaying
            webBrowserDisplay.ScriptErrorsSuppressed = true;
        }

        //the code below handle button "go forward"
        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowserDisplay.GoForward();
        }
        //the code below handle button "go back"
        private void buttonBackward_Click(object sender, EventArgs e)
        {
            webBrowserDisplay.GoBack();
        }
        //the code below handle button "go home"
        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowserDisplay.GoHome();
        }
        //the code below handle button "print"
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            webBrowserDisplay.ShowPrintDialog();
        }
        //the code below handle button "preview print"
        private void buttonPreview_Click(object sender, EventArgs e)
        {
            webBrowserDisplay.ShowPrintPreviewDialog();
        }
        //the code below handle button "refresh"
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowserDisplay.Refresh();
        }
        //the code below linked Goggle to a button
        private void buttonGoogle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void buttonMSEdge_Click(object sender, EventArgs e)
        {
            //the button below link MS Edge to the button
            System.Diagnostics.Process.Start("https://www.microsoft.com/en-us/edge");
        }

        //the code below linked Firefox
        private void buttonFireFox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mozilla.org/en-US/firefox/new/");
        }

        //linked Chrome
        private void buttonChrome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/chrome/");
        }

        //linked Instagram
        private void buttonInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        //linked YouTube
        private void buttonYouTube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        //linked Amazon
        private void buttonAmazon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com/");
        }

        //linked LinkedIn
        private void buttonLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/");
        }

        //linkedFacebook
        private void buttonFaceBook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void buttonBing_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/");
        }

        private void buttonWaze_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.waze.com/live-map/");
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps");
        }

        private void MyMainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            FormCalendar f1 = new FormCalendar();   
            f1.ShowDialog();
        }

        private void buttonFavorite_MouseHover(object sender, EventArgs e)
        {
            buttonBookMark.BackColor = Color.Red;
        }

        private void buttonFavorite_MouseLeave(object sender, EventArgs e)
        {
            buttonBookMark.BackColor= Color.Blue;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            buttonShow.BackColor = Color.Black;
        }

        private void buttonHistory_MouseLeave(object sender, EventArgs e)
        {
            buttonShow.BackColor= Color.Green;
        }

        private void buttonGo_Click_1(object sender, EventArgs e)
        {
            webBrowserDisplay.Navigate(comboBoxWebSite.Text);
        }

        //the code below handle the progress bar using event handler
        private void webBrowserDisplay_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch
            {

            }

        }

        //the code below for the combo box to display the website URL
        private void webBrowserDisplay_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)

        {
            comboBoxWebSite.Text = webBrowserDisplay.Url.ToString();
            History.Items.Add(comboBoxWebSite.Text);//save the search history to the history list box
            
        }

        //this line of code handle the clear button in favorite list
        private void button2_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
        }

        //the line of code below handle the clear history button
        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
        }

        //the below line of code handle the hide button for the entire tab control
        private void buttonHideHistory_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
        }

        //this line of code link the tab control to the book mar button
        private void buttonBookMark_Click(object sender, EventArgs e)
        {
            Favorites.Items.Add(comboBoxWebSite.Text);
        }

        //this line of code hind the entire tab control
        private void buttonHideFavorite_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
        }

        //this line of code show control tab for history and favorite
        private void buttonShow_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
        }

        //this line of code link teaxt reader form
        private void buttonLinkTextReader_Click(object sender, EventArgs e)
        {
            Text_Reader f1 = new Text_Reader();
            f1.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //import sound:solution explorer-resources-under image:choose audio, then under Add resources: choose add file 
        //(must convert sound file to WAV)
        private void buttonPlayMusic_Click(object sender, EventArgs e)//autogenerate method
        {
            //create a new sound object to play a new sound
            //add a library on the top:using System IO
            SoundPlayer objectSoundPlayer = new SoundPlayer(Properties.Resources.memories); //create object-objectSoundPlayer. notice lower case first letter
            objectSoundPlayer.Play();
        }

        private void buttonStopMusic_Click(object sender, EventArgs e)
        {
            SoundPlayer objectSoundPlayer = new SoundPlayer(Properties.Resources.memories);
            objectSoundPlayer.Stop();
        }
    }
}
