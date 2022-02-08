using Entities.Concrete;

namespace Business.Adapters.Abstract
{
    public interface IMailService
    {
        void SendMailForPassword(User user);
        void SendMailForAnnouncements(string mail);
    }
}