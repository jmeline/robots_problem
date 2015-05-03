using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        // 1
        // Naming Note: if the name of our event is going to be 'VideoEncoded' then append EventHandler
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2
        // public event VideoEncodedEventHandler VideoEncoded;

        // Simpler option
        public event EventHandler<VideoEventArgs> VideoEncoded;

        // 3
        // Should begin with 'On' in the name
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(2000);
            OnVideoEncoded(video);
        }
    }
}
