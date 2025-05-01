using Calculator_with_Delegates;
using NotificationSystem;

namespace NotificationSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Notification n1 = new Notification("tomorrow will be holyday");
        HR h1 = new HR();
        IT it1 = new IT();

        n1.notify += h1.HrSend;
        n1.notify += it1.Itsend;

        n1.Alert();

    }
}