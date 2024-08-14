using System;
using System.Net;
using System.Net.Mail;
using TaskSMTP;
using TaskReadandWrite;
using Read_Date_From_JSON_File;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using ReadWeathercastDatafromJSON;
using Newtonsoft.Json;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonRead data = new JsonRead();
            data.Climate();

            //var serviceCollection = new ServiceCollection();

            //IConfiguration configuration;
            //configuration = new ConfigurationBuilder()
            //  .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
            //.AddJsonFile("appsettings.json")
            //.Build();

            //serviceCollection.AddSingleton<IConfiguration>(configuration);

            // SMTP obj = new SMTP(configuration);
            // obj.Send();



            // ReadandWrite data = new ReadandWrite();
            // data.File();



            // SMTP obj = new SMTP();
            //obj.FileLog();
            //obj.Send();
        }

    }
}
