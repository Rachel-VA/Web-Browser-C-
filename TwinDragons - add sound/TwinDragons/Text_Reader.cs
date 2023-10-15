using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//add using system IO
using System.Speech;
using System.Speech.Synthesis;//go to solution explorer-add reference:system speech 


namespace TwinDragons
{
    public partial class Text_Reader : Form
    {
        SpeechSynthesizer reader = new SpeechSynthesizer(); // create speech object
        public Text_Reader()
        {
            InitializeComponent();
            labelText.Top = 80;   //set the text height for moving text in the label
        }
        //this code for timer 2
        int len = 0;
        string text;

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Text_Reader_Load(object sender, EventArgs e)
        {

        }
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            Stream str;
            labelText.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((str = openFileDialog.OpenFile()) != null)
                {
                    string fname = openFileDialog.FileName;
                    string filetxt = File.ReadAllText(fname);
                    labelText.Text = filetxt;
                }
            }
            
        }
        //the code below enable the read button, using auto voice
        private void buttonRead_Click(object sender, EventArgs e)
        {
            text = labelText.Text;
            len = text.Length;
            timer1.Start();//timer enable text moving as it read aloud
            timer2.Start();
            reader.SpeakAsync(labelText.Text);
        }

        //the code below handle the pause funtion for the pause button
        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                    timer1.Stop();
                    timer2.Stop();
                }
            }
        }

        //the code below handle resume function
        private void buttonResume_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                    timer1.Start();
                    timer2.Start();
                }
            }
        }

        //the code below handle the stopfunction button
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
                timer1.Stop();
                timer2.Stop();
                labelText.Text = "";
            }
        }

        //the code below handle the moving text within the label. set timer property 150 internval
        private void timer1_Tick(object sender, EventArgs e)// the timer works without clicking
        {
            labelText.ForeColor = Color.Red;
            labelText.Top -= 1;
        }

        //set timer2 property 50 interval
        int counter = 0;    
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter ++; 
            if (counter > len)
            {
                counter = 0;
                labelText.Text = text;
                labelText.Top = 80;
                timer1.Stop();
                timer2.Stop();
            }
            else
            {
                labelText.Text =text.Substring(0,counter);
            }
        }
    }
}
