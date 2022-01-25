using System;
using System.Collections.Generic;
using System.Linq;
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
            IUserDal userDal = new EfUserDal();
            var userMan = new UserMan(userDal);

            User user1 = new User();


            //user1.UserId = 3005;
           // user1.Email = "oguzhan@oguzhan.com ";
           // user1.BloodTypeId = 2;
           // user1.IsMernisOk = true;
           // user1.IsValidate = true;
           // user1.Name = "Oğuzhan";
           // user1.LastName = "Öztürk";
           // user1.PhoneNumber = "5312939472";
           // user1.Password = "123";
           // user1.IdentityNumber = "2587413698";
           // user1.BirthDay = new DateTime(2000,10,04);
           //
           //
           // var list = userMan.GetAll();
           // Console.WriteLine(list.GetType());
           //
           //
           //  userMan.Delete(user1);
           //
            
            //userMan.Add(user1);
           
            

            // User user1 = new User();
            // user1.UserId = 1;
            // userMan.Delete(user1);
        }
    }
}