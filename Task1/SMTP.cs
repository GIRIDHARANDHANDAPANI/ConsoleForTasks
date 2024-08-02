using System;
using System.Net;
using System.Net.Mail;
namespace TaskSMTP
{
    public class SMTP
    {
        public void Send()
        {
            Console.WriteLine("Hello World!");
            SendEmail(GetUserName(), GetPassword());
            Console.ReadLine();
        }
        public static void SendEmail(string fromaddress, string password)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(fromaddress, password)

            };
            string subject = "youtube video"; string body = $"this is the main email sent@{DateTime.UtcNow:F}";

            try
            {
                Console.WriteLine("sending email ************");
                email.Send(fromaddress, Toaddress(), subject, body);
                Console.WriteLine("email sent ************");
            }
            catch (SmtpException e)
            {

                Console.WriteLine(e);
            }
        }
        public static string GetUserName()
        {
            return "giridharandhandapani@gmail.com";
        }
        public static string GetPassword()
        {
            return "utwdijnmhemvzbfh";
        }

        public static string Toaddress()
        {
            return "sureshkumarduraisamy@anaiyaantechnologies.com";
        }
    }
}
