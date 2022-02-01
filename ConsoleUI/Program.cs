using System;
using System.Collections.Generic;
using System.Linq;
using Business.Adapters.Concrete;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Conctrete;
using Entities.Concrete;


namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICityDal city = new EfCityDal();
            CityMan cityMan = new CityMan(city);

            var cities = cityMan.getAll();

            foreach (var a in cities.Data)
            {
                Console.WriteLine(a.CityName);
            }


        }
    }
}