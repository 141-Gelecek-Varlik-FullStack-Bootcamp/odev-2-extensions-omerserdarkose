using Core.Extensions;
using Entities;
using Entities.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //dependency Injection
            ServiceProvider serviceProvider = new ServiceCollection()
                                           .AddTransient<ICustomer, Customer>()
                                           .BuildServiceProvider();

            ICustomer customer = serviceProvider.GetService<ICustomer>();

            customer.Id = 1;
            customer.FirstName = "Serdar";
            customer.LastName  = "Kose";
            customer.PhoneNumber = "5303332211";

            //1.extension ornegi
            Console.WriteLine(customer.ContactInfo());
            //2.extension ornegi
            Console.WriteLine(customer.InstanceType());  //output: Entities.Customer

            Console.ReadLine();
        }
    }
}
