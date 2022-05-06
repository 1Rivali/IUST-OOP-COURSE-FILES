using System;

namespace ConstructorOverloading
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
            SetTime(0, 0, 0);
        }
        public Time(int h)
        {
            SetTime(h, 0, 0);
        }
        public Time(int h, int m)
        {

            SetTime(h, m, 0);
        }
        public Time(int h, int m, int s)
        {
            SetTime(h, m, s);
        }
        public Time(Time time) : this(time.Hour, time.Minute, time.Second)
        { }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value < 24)
                    hour = value;
                else
                    Console.WriteLine("Hour " + value + " Hour must be 0-23");
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value >= 0 && value < 60)
                    minute = value;
                else
                    Console.WriteLine("Minute " + value + " Minute must be 0-59");
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value >= 0 && value < 60) second = value;
                else
                    Console.WriteLine("Second " + value + " Second must be 0-59");
            }
        }
        public void SetTime(int h, int m, int s)
        {
            Hour = h;
            Minute = m;
            Second = s;
        }
        public string ToUniversalString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);
        }


        public string ToStandardString()
        {
            return string.Format("{0}:{1:D2}:{2:D2} {3}",
            ((Hour == 0 || Hour == 12) ? 12 : Hour % 12),
           Minute, Second, (Hour < 12 ? "AM" : "PM"));
        }

    }
    public class TimeTest
    {
        public static void Main()
        {
            Time t1 = new Time();
            Time t2 = new Time(2);
            Time t3 = new Time(21, 34);
            Time t4 = new Time(12, 25, 42);
            Time t5 = new Time(t4);
            Console.WriteLine("t1: all arguments defaulted");
            Console.WriteLine(" {0}", t1.ToUniversalString());
            Console.WriteLine(" {0}\n", t1.ToStandardString());
            Time t6;
            t6 = new Time(27, 74, 99);
            Console.WriteLine(" {0}", t6.ToUniversalString());
        }
    }
}






