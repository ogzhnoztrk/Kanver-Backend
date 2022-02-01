using System;
using System.Collections.Generic;
using System.Linq;
using Business.Adapters.Abstract;
using Business.Adapters.Concrete;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Conctrete;
using Entities.Abstract;
using Entities.Concrete;
using Google.Protobuf;


namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IMailService service = new MailService();
            User user= new User();

            user.Email = "oguzhanoztrk00@gmail.com";
            user.Password = "asdasdasd";


            //var result = service.SendMailForPassword(user);
            //Console.WriteLine(result);

        }
    }
}