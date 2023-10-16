using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Inheritance_132
{
    class VideoPost : Post
    {
        //member fields
        private Timer timer;
        private bool isPlaying = false;
        private int currentDuration = 0;

        //Properties
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string author, string videoURL, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Author = author;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
            this.currentDuration = 0;

        }

        public override string ToString()
        {
            return String.Format("ID: {0} - Video Title: {1} - Author: {2} - VideoURL: {3} - Length: {4}",
                this.ID, this.Title, this.Author, this.VideoURL, this.Length);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stopped at {0}s", currentDuration);
            currentDuration = 0;
            timer.Dispose();
        }

        private void TimerCallBack(object o)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
    }
}
