using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Date_From_JSON_File
{
    class Test
    {
        private readonly IConfiguration configuration;
        public Test(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void TestMethod()
        {
            var dataFromJsonFile = configuration.GetSection("From").Value;
            Console.WriteLine(dataFromJsonFile);
            var dataFromJsonFile1 = configuration.GetSection("To").Value;
            Console.WriteLine(dataFromJsonFile1);
        }
    }
}
