using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _07.ExecuteDelegateForClassTimer
{
    public class TimerTest
    {
        public static void Main()
        {
            TimerEvent te1 = new TimerEvent(ExecuteEach3Seconds);
            Timer tm1 = new Timer(3, te1);

            TimerEvent te2 = new TimerEvent(SecondExecuteEach5Seconds);
            Timer tm2 = new Timer(5, te2);

            Timer tm3 = new Timer(new TimerEvent(delegate() { Console.WriteLine("Hi each second"); }));

            Thread timer1Thread = new Thread(new ThreadStart(tm1.Run));
            timer1Thread.Start();

            Thread timer2Thread = new Thread(new ThreadStart(tm2.Run));
            timer2Thread.Start();

            Thread timer3Thread = new Thread(new ThreadStart(tm3.Run));
            timer3Thread.Start();
        }

        private static void ExecuteEach3Seconds()
        {
            Console.WriteLine("You can only see me every 3rd second");
        }

        private static void SecondExecuteEach5Seconds()
        {
            Console.WriteLine("I am here every 5 seconds lol");
        }
    }
}
