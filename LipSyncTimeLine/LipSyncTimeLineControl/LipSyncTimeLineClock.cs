﻿namespace LipSyncTimeLineControl
{
    public class LipSyncTimeLineClock
    {
        public double Value { get; set; }

        public bool IsRunning { get; private set; }

        public void Pause()
        {
            IsRunning = false;
        }

        public void Play()
        {
            IsRunning = true;
        }
    }
}
