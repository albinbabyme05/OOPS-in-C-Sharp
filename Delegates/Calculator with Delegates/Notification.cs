using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_with_Delegates
{
    public delegate void NotificationHandler();
    public class Notification
    {
        public string Text;
        public NotificationHandler notify;

        public Notification(string text)
        {
            Text = text;
        }

        public void Alert()
        {
            Console.WriteLine("new notification added"+Text);
            notify();
        }
    }
}
