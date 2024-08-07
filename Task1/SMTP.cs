using System;
using System.Net;
using System.Net.Mail;
using System.IO;
namespace TaskSMTP
{
    public class SMTP
    {
        public void FileLog()
        {
            string file = $"File_{DateTime.Now.ToString("yyyy-mm-dd")}.txt";
            try
            {
                Send();
                StreamWriter sw = new StreamWriter($"D:{file}.txt",false);

                sw.WriteLine($"Sucessfully sent Mail in {DateTime.Now.ToString("yyyy-mm-dd")}");
                sw.Close();
            }
            catch(Exception e)
            {
                StreamWriter sw1 = new StreamWriter($"D:{file}.txt",false);
                sw1.WriteLine(e.StackTrace);
                sw1.Close();
            }
        }
        public void Send()
        {
            Console.WriteLine("Hello World!");
            SendEmail(GetUserName(), GetPassword());
            
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
            return "sureshkumar.duraisamy@anaiyaantechnologies.com";
        }
    }
}
