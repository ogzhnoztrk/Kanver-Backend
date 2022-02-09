using Business.Adapters.Abstract;
using Business.Adapters.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ISmsService service = new SmsService();
            service.SendSms("+905312939472");
        }
    }
}