using System;
using Microsoft.AspNet.Hosting;

namespace HelloWebFullAppDomainManagerPrototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This sample shows the current working prototype that fixes the application base on .NET Framework.
            // This is important so that configuration files, static files and razor views can be found by libraries
            // referenced by the application.

            // In the other samples, the application base points to where the ".exe" is located. This is problematic
            // at development time because it means static files, views and configuration files need to be copied (via compile)
            // before running.
#if NET451
            Console.WriteLine($"AppDomain.Id = {AppDomain.CurrentDomain.Id}");
            Console.WriteLine($"AppDomain.FriendlyName = {AppDomain.CurrentDomain.FriendlyName}");
            Console.WriteLine($"AppDomain.BaseDirectory = {AppDomain.CurrentDomain.BaseDirectory}");
#endif
            // The real application logic goes here
            WebApplication.Run(args);
        }
    }
}