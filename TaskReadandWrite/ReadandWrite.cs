using System;
using System.IO;

namespace TaskReadandWrite
{
    public class ReadandWrite
    {
        public void File()
        {
            string data;
            StreamReader Reader = null;
            StreamWriter Writer = null;
            try
            {
                Reader = new StreamReader("C:\\Users\\TEC BUDDY\\Desktop\\Read2.txt");

                data = Reader.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = Reader.ReadLine();
                }
                Reader.Close();
                Writer = new StreamWriter("C:\\Users\\TEC BUDDY\\Desktop\\Write2.txt");
                Writer.WriteLine("Hi i am Giri");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Writer.Close();
            }
        }
    }
}
