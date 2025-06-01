using System;

namespace cod
{
    static class AppConfig
    {
        public static string ConnectionString { get; set; }
        public static bool EnableLogging { get; set; }
        public static int MaxRetries { get; set; }

        static AppConfig()
        {
            ConnectionString = "Идет подключение...";
            EnableLogging = true;
            MaxRetries = 3;

        }
    }
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine($"ConnectionString = {AppConfig.ConnectionString}, " +
                $"EnableLogging = {AppConfig.EnableLogging}, " +
                $"MaxRetries = {AppConfig.MaxRetries}");

            AppConfig.ConnectionString = "Подключение установлено!!!";
            AppConfig.EnableLogging = false;
            AppConfig.MaxRetries = 0;

            System.Console.WriteLine($"ConnectionString = {AppConfig.ConnectionString}, " +
                $"EnableLogging = {AppConfig.EnableLogging}, " +
                $"MaxRetries = {AppConfig.MaxRetries}");




        }
    }
}