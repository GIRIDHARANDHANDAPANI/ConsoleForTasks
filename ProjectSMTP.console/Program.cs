using System;
using System.Net;
using System.Net.Mail;
using TaskSMTP;
using TaskReadandWrite;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
           // ReadandWrite data = new ReadandWrite();
           // data.File();



            SMTP obj = new SMTP();
            obj.Send();
        }

    }
}
