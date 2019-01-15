using System;
using System.Windows;
using System.Windows.Threading;
using System.ComponentModel;

namespace DigitalClock
{
    public class ClockTicker1 : DependencyObject
    {
        public static DependencyProperty DateTimeProperty = DependencyProperty.Register("DateTime", typeof(string), typeof(ClockTicker1));

        public string DateTime1
        {
            set { SetValue(DateTimeProperty, value); }
            get { return (string)GetValue(DateTimeProperty); }
        }

        public ClockTicker1()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerOnTick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        void TimerOnTick(object sender, EventArgs args)
        {
            DateTime1 = DateTime.Now.ToString("yyyyMMdd HHmmss");
        }
    }
}