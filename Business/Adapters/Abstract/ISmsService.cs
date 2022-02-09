namespace Business.Adapters.Abstract
{
    public interface ISmsService
    {
        void SendSms(string PhoneNumber);
    }
}