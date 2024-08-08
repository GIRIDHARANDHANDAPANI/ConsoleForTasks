using System;
using System.Net;
using System.Net.Mail;
using TaskSMTP;
using TaskReadandWrite;
using Read_Date_From_JSON_File;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadDate obj = new();
            obj.DI();



           // ReadandWrite data = new ReadandWrite();
           // data.File();



           // SMTP obj = new SMTP();
            //obj.FileLog();
            //obj.Send();
        }

    }
}
