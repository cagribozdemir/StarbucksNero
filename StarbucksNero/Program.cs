using StarbucksNero.Abstract;
using StarbucksNero.Adapters;
using StarbucksNero.Concrete;
using StarbucksNero.Entities;
using System;

namespace StarbucksNero
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" });
            Console.ReadLine();
        }
    }
}