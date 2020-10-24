using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.persistance.ConnectionProvider;
using api.persistance.Repositories.Interface;
using api.persistance.Repositories.Repository;
using api.service.Interface;
using api.service.Services;
using Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace api.web
{
#pragma warning disable CS1591
    public class Program
    {
        public static void Main(string[] args)
        {       
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
#pragma warning restore CS1591
}
