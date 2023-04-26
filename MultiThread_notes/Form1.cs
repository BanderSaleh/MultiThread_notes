using System;

namespace MultiThread_notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Form 1 starts running with this line
            DisplayToRTB("Hello World!"); // Runs a Method I created below

        }


        // Methods
        public void DisplayToRTB(string message)
        {
            richTextBox1.Text += message + "\n"; // Add inputed message to a new line
            // Test this method and see if our code locks up <-- Important thing to check for with writing MultiThread code

        }

        public void LongProcess()
        {

        }
        public void ShortProcess()
        {

        }

        public async void LongAsync(int number)
        {
            DisplayToRTB($"LongAsync started : Thread {number}");

            // Replace Thread.Sleep with async version
            await Task.Delay(4000);

            DisplayToRTB("LongAsync Ended");
        }

        public async void LoopAsync()
        {
            // [insert stopwatch method code here]
            // includes a Delegates method type
        }







        // Click-Events
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRunSync_Click(object sender, EventArgs e)
        {

        }

        private void btnRunAsync_Click(object sender, EventArgs e)
        {
            LongAsync(1);
            ShortProcess();
        }

        private void btnMultiThread_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                LongAsync(i);
            }
        }

        private void btnStopWatch_Click(object sender, EventArgs e)
        {

            // Insert code to calculate how long (seconds) it takes to run a specified line of code

        }

        


    }
}