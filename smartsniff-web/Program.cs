﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace smartsniff_web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] urls = new string[] { "http://localhost:5001" };

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls(urls)
                .Build();

            host.Run();
        }
    }
}