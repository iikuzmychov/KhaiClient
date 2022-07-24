using KuzCode.KhaiApiClient;
using System;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var khaiClient = new KhaiClient();
            khaiClient.ConnectAsync().Wait();

            while (true)
            {

            }
        }
    }
}
