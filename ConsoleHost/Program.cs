using Microsoft.Owin.Hosting;
using Serilog;
using System;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo
                .LiterateConsole(outputTemplate: "{ Timestamp: HH: MM} [{Level}] ({Name:l}){NewLine} {Message}{NewLine}{Exception}")
                .CreateLogger();

            using (WebApp.Start<ConsoleHost.IdServer.Startup>("https://localhost:44333/"))
            {
                Console.WriteLine("server running...");
                Console.ReadLine();
            }
        }
    }
}
