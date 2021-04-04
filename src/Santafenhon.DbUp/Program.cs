using DbUp;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Reflection;

namespace Santafenhon.DbUp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
            var connectionString =
                args.FirstOrDefault()
                ?? config.GetConnectionString("DefaultConnection");

            Console.WriteLine($"Connecting to {connectionString}");

            var upgrader =
                DeployChanges.To
                    .SQLiteDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();


            if (upgrader.TryConnect(out var err))
            {
                var result = upgrader.PerformUpgrade();

                if (!result.Successful)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result.Error);
                    Console.ResetColor();
#if DEBUG
                    Console.ReadLine();
#endif
                    return -1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Cannot Connect: '{err}'");
                Console.ResetColor();
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            return 0;
        }
    }
}
