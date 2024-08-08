using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Read_Date_From_JSON_File
{
    public class ReadDate
    {
       public void DI()
        {
            var serviceCollection = new ServiceCollection();

            IConfiguration configuration;
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json")
                .Build();

            serviceCollection.AddSingleton<IConfiguration>(configuration);
            serviceCollection.AddSingleton<Test>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var testInstance = serviceProvider.GetService<Test>();
            testInstance.TestMethod();
        }
        
    }
}
