using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClient.Services;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MySportServiceClient client = new MySportServiceClient();
            int score = client.GetScore("Giants");
            Console.WriteLine("Score = " + score);
            Console.Read();
        }
    }
}
