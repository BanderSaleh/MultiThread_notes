namespace MultiThread_notes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            btnRunSync = new Button();
            btnRunAsync = new Button();
            btnMultiThread = new Button();
            btnStopWatch = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(455, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(267, 290);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnRunSync
            // 
            btnRunSync.Location = new Point(76, 81);
            btnRunSync.Name = "btnRunSync";
            btnRunSync.Size = new Size(137, 34);
            btnRunSync.TabIndex = 1;
            btnRunSync.Text = "Run ( Sync )";
            btnRunSync.UseVisualStyleBackColor = true;
            btnRunSync.Click += btnRunSync_Click;
            // 
            // btnRunAsync
            // 
            btnRunAsync.Location = new Point(76, 155);
            btnRunAsync.Name = "btnRunAsync";
            btnRunAsync.Size = new Size(137, 34);
            btnRunAsync.TabIndex = 2;
            btnRunAsync.Text = "Run ( ASync )";
            btnRunAsync.UseVisualStyleBackColor = true;
            btnRunAsync.Click += btnRunAsync_Click;
            // 
            // btnMultiThread
            // 
            btnMultiThread.Location = new Point(76, 229);
            btnMultiThread.Name = "btnMultiThread";
            btnMultiThread.Size = new Size(137, 34);
            btnMultiThread.TabIndex = 3;
            btnMultiThread.Text = "Run ( Multiple )";
            btnMultiThread.UseVisualStyleBackColor = true;
            btnMultiThread.Click += btnMultiThread_Click;
            // 
            // btnStopWatch
            // 
            btnStopWatch.Location = new Point(76, 299);
            btnStopWatch.Name = "btnStopWatch";
            btnStopWatch.Size = new Size(137, 34);
            btnStopWatch.TabIndex = 4;
            btnStopWatch.Text = "Stopwatch Example";
            btnStopWatch.UseVisualStyleBackColor = true;
            btnStopWatch.Click += btnStopWatch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStopWatch);
            Controls.Add(btnMultiThread);
            Controls.Add(btnRunAsync);
            Controls.Add(btnRunSync);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnRunSync;
        private Button btnRunAsync;
        private Button btnMultiThread;
        private Button btnStopWatch;
    }
}