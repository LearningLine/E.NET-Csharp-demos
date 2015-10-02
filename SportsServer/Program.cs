using System;
using System.ServiceModel;

namespace SportsServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof (SportService)))
            {
                host.Open();
                Console.WriteLine("The server is running");
                Console.Read();
            }



        }
    }
}
