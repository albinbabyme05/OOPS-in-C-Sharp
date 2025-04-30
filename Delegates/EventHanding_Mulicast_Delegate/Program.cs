using EventHanding_Mulicast_Delegate;
using System.Net.Http.Headers;

namespace EventHanding_Mulicast_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("Test Video");
            EmailService email = new EmailService();
            SMSService sms = new SMSService();

            // using multicast delegate to point to different methods
            video.onVideoUploaded += email.SendEmail;
            video.onVideoUploaded += sms.SendSMS;

            video.UploadVideo();

        }
    }
}
