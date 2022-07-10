﻿using nanoFramework.Hosting;

using Microsoft.Extensions.Logging;

namespace nanoFramework.Logging
{
    public class Program
    {
        public static void Main()
        {
            IHost host = CreateHostBuilder().Build();
            
            host.Start();
            host.Stop();
        }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddLogging(LogLevel.Debug);
                    services.AddHostedService(typeof(LoggingService));
                });
    }
}
