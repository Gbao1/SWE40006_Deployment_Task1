using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Clock
    {
        Counter _hour = new Counter("hour");
        Counter _minute = new Counter("minute");
        Counter _second = new Counter("second");

        public void Ticks()
        {
            _second.Increment();
            if (_second.Ticks > 59)
            {
                _second.Reset();
                _minute.Increment();
                if (_minute.Ticks > 59)
                {
                    _minute.Reset();
                    _hour.Increment();
                    if (_hour.Ticks > 23)
                    {
                        Reset();
                    }
                }
            }
        }

        public void Reset()
        {
            _second.Reset();
            _minute.Reset();
            _hour.Reset();
        }

        public void SetTime(string t)
        {
            string[] array = t.Split(":");

            _hour = new Counter("hour", int.Parse(array[0]));
            _minute = new Counter("minute", int.Parse(array[1]));
            _second = new Counter("second", int.Parse(array[2]));
        }

        public string CurrentTime()
        {
            return $"{_hour.Ticks:D2}:{_minute.Ticks:D2}:{_second.Ticks:D2}"; //At least 2 digits
        }
    }

}
