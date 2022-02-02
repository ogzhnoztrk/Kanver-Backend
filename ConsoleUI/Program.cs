using Business.Adapters.Abstract;
using Business.Adapters.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IMailService service = new MailService();
            var user = new User();

            user.Email = "oguzhanoztrk00@gmail.com";
            user.Password = "asdasdasd";


            //var result = service.SendMailForPassword(user);
            //Console.WriteLine(result);
        }
    }
}