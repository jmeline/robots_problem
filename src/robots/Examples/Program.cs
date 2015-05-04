using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Program
    {
        // Detegates
        //  Agreement / Contract between Publisher and Subscriber
        // Determines the signature of the event handler method in Subscriber

        // Events
        //  A mechianism for communicating between objects
        //  used in loosely copuled applications

        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();      // publisher
            var mailService = new MailService();        // subscriber
            var messageService = new MessageService();  //subscriber

            // subscribe to publisher
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }


}
