using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Timer timer;
        private int elapsedSeconds = 0;
        private bool isRunning = false;

        public Form1()
        {
            InitializeComponent();

            // Setup timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;

            // Initialize UI text
            labelClock.Text = "00:00:00";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            TimeSpan ts = TimeSpan.FromSeconds(elapsedSeconds);
            labelClock.Text = ts.ToString(@"hh\:mm\:ss");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer.Start();
                isRunning = true;
            }
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isRunning = false;
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isRunning = false;
            elapsedSeconds = 0;
            labelClock.Text = "00:00:00";
        }

        private void LabelClock_Click(object sender, EventArgs e)
        {

        }
    }
}



