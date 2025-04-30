using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHanding_Mulicast_Delegate
{
    // when ever i uploaded video i need to pass info to SMS and Email to people
    // so creating a delegate to point 
    public delegate void OnVideoUploaded();

    public class Video
    {
        public OnVideoUploaded onVideoUploaded;
        public string Name { get; set; }

        public Video(string name)
        {
            Name = name;
        }

        public void UploadVideo()
        {
            Console.WriteLine("Uploading Video");
            Thread.Sleep(2000);
            Console.WriteLine("Video Uploaded");

            // when the video upload complete pointing to sms and email serivces
            onVideoUploaded();
        }
    }
}
