﻿using Contracts;
using LoggerService;
namespace PersonAPI.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
         options.AddPolicy("CorsPolicy", builder =>
         builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
        });


        public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
        });




    }
}
