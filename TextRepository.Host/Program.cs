using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TextRepository.Host
{
    public static class Program
    {
        public static void Main()
        {
            var apiPort = "10001";
            var apiHost = WebHost.CreateDefaultBuilder()
                .UseUrls($"http://*:{apiPort}")
                .UseStartup<Api.Startup>()
                .Build();
            apiHost.Start();
            Console.WriteLine($"Started web api on port {apiPort}");

            var uiPort = "10002";
            var uiHost = WebHost.CreateDefaultBuilder()
                .UseUrls($"http://*:{uiPort}")
                .UseStartup<UI.Startup>()
                .Build();
            uiHost.Start();
            Console.WriteLine($"Started UI on port {uiPort}");

            Console.Read();
        }
    }
}
