using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace ProductivityTracker
{
    class Tracker
    {

        protected Stopwatch timer;
        public string category;
        public Tracker(string inCat)
        {
            timer = new Stopwatch();
            category = inCat;
        }
        public void startTiming()
        {
            timer.Start();
        }
        public void stopTiming()
        {
            timer.Stop();
        }
        public TimeSpan currTime()
        {
            return timer.Elapsed;
        }
    }
}
