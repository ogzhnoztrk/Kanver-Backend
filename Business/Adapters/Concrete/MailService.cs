using System.Net;
using System.Net.Mail;
using Business.Adapters.Abstract;
using Entities.Concrete;

namespace Business.Adapters.Concrete
{
    public class MailService : IMailService
    {
        private const string Password = "Kanver123456";
        private const string Email = "kanverdeneme@gmail.com";
        private readonly SmtpClient client = new("smtp.gmail.com", 587);
        private readonly MailMessage message = new();

        public void SendMailForPassword(User user)
        {
            client.Credentials = new NetworkCredential(Email, Password);
            client.EnableSsl = true;

            message.To.Add(user.Email);
            message.From = new MailAddress("kanverdeneme@gmail.com");
            message.Subject = "Şifremi Unuttum";
            message.Body = "MEVCUT ŞİFRENİZ: " + user.Password;
            client.Send(message);
        }
    }
}