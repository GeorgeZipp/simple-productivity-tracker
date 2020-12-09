using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
namespace ProductivityTracker
{
    class Dashboard
    {
        private Tracker [] prim;
        private int currIndex;
        private int trackedIndex;
        private TimeSpan ts;
        private const int DEFAULTSIZE = 5;
        public Dashboard(string category)
        {
            prim = new Tracker[DEFAULTSIZE];
            prim[0] = new Tracker(category);
            currIndex = 0;
            trackedIndex = 0;
            prim[0].startTiming();
        }
        private void startTiming(int index)
        {
            prim[index].startTiming();
        }
        private void stopTiming(int index)
        {
            prim[index].stopTiming();
        }
        public void switchCat(string category)
        {
            int indexCheck = -1;
            for(int i = 0; i < prim.Length; i++)
            {
                if(category == prim[i].category)
                {
                    indexCheck = i;
                    break;
                }
            }
            if (indexCheck > -1 && indexCheck != currIndex)
            {
                prim[currIndex].stopTiming();
                prim[indexCheck].startTiming();
                currIndex = indexCheck;
            }
        }
        public void addCat(string category)
        {
            if (currIndex + 1 >= prim.Length)
                Array.Resize(ref prim, prim.Length + DEFAULTSIZE); //resizes array to + 5 of current size
            trackedIndex++;
            prim[trackedIndex] = new Tracker(category);
        }
        public void displayCurrTimeElapsed()
        {
            ts = prim[currIndex].currTime();
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Time Spent on " + prim[currIndex].category + " " + elapsedTime);
        }
        public void displayDashboard()
        {
            string elapsedTime;
            for (int i = 0; i < prim.Length; i++)
            {
                if(prim[i] != null)
                {
                    ts = prim[i].currTime();
                    elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    Console.WriteLine("Time Spent on " + prim[i].category + " " + elapsedTime);
                }
            }
        }
    }
}
