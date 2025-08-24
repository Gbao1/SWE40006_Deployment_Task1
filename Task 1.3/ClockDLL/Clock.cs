using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ClockDLL
{
    public class ClockCounter
    {
        private int ElapsedSeconds { get; set; }
        private bool Running { get; set; }

        public void Start() => Running = true;
        public void Stop() => Running = false;
        public void Reset() { ElapsedSeconds = 0; Running = false; }

        public void Tick()
        {
            if (Running) ElapsedSeconds++;
        }

        public string GetTimeString()
        {
            return TimeSpan.FromSeconds(ElapsedSeconds).ToString(@"hh\:mm\:ss");
        }
    }
}

