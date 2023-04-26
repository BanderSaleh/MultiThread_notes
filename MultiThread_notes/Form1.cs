namespace MultiThread_notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayToRTB("Hello World!");
            
        }


        // Methods
        public void DisplayToRTB(string message)
        {
            richTextBox1.Text += message + "\n";
        }

        //publicc void LongProcess()


        // Click-Events
        private void btnRunSync_Click(object sender, EventArgs e)
        {

        }

        private void btnRunAsync_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}