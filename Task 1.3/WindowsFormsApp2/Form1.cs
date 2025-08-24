using System;
using System.Windows.Forms;
using ClockDLL;
using UtilsDLL;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly ClockCounter _clock = new ClockCounter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _clock.Tick();
            labelClock.Text = TimeFormatter.PrefixLabel(_clock.GetTimeString());
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            _clock.Start();
            timer.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _clock.Stop();
            timer.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _clock.Reset();
            labelClock.Text = TimeFormatter.PrefixLabel(_clock.GetTimeString());
        }
    }
}
