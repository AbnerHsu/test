using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Pattern.Builder;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //VehicleBuilder builder;
            IServiceCollection service = new ServiceCollection();
            service.AddTransient<VehicleBuilder>((s) => new CarBuilder() );
            Shop shop = new Shop();
            //List<VehicleBuilder> builderLists = new List<VehicleBuilder>();

            var serviceProvider =  service.BuildServiceProvider();

            shop.Construct(serviceProvider.GetService<VehicleBuilder>());
            shop.GetVehicle.Vehicle.Show();
            serviceProvider.GetService<VehicleBuilder>().Vehicle.Show();

            IServiceCollection serviceSingleton = new ServiceCollection();

            //builderLists.Add(new ScooterBuilder());
            //builderLists.Add(new CarBuilder());
            //builderLists.Add(new MotorCycleBuilder());

            /*foreach (var builder in builderLists)
            {
                shop.Construct(builder);
                builder.Vehicle.Show();
            }*/
            Console.ReadKey();
        }
    }
}
