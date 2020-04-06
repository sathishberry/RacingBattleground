using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace RacingBattleground
{
    class MainClass
    {
        private static IServiceProvider _serviceProvider;
        public static void Main(string[] args)
        {

            //RacingBattle battle;
            try
            {
                RegisterServices();
                var app = _serviceProvider.GetService<IRacingBattle>();

                while (true)
                {
                    Console.WriteLine("Hi please choose any option given below");

                    foreach (RaceInformation enumName in Enum.GetValues(typeof(RaceInformation)))
                    {
                        Console.WriteLine(string.Format("\t{0}.{1}", (int)enumName, enumName.ToString()));
                    }
                    Console.Write("Enter your  chooise:");
                    var option = Convert.ToInt32(Console.ReadLine());

                    
                    //var app = serviceProvider.GetService<RacingBattle>();
                    var arg = (RaceInformation)option;
                    app.Run(arg);
                    Console.WriteLine("Note: Other than Y/y is exit.");
                    Console.WriteLine("Would you like to Continue?(Y/N):");
                    var _continue = Console.ReadLine();
                    if (_continue.ToLower() == "y") continue; else break;
                }

                //Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IRacingBattle, RacingBattle>();
            collection.AddScoped<IDriverInformation, DriverInformation>();
            collection.AddScoped<IDriverModel, DriverModel>();

            _serviceProvider = collection.BuildServiceProvider();
        }
        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }


    }

    public enum RaceInformation
    {
        GetTopDriversDetails = 0,
        GetAllDriverDetails = 1
    }
}
