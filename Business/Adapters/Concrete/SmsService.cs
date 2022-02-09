using Business.Adapters.Abstract;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Business.Adapters.Concrete
{
    public class SmsService : ISmsService
    {
        private const string accountSid = "AC99fa5e45d78df1fd80f6b7b9f22e2811";
        private const string authToken = "dba89d823f8a969ef7a26b0b5befee1e";

        public void SendSms(string phoneBumber)
        {
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(new PhoneNumber(phoneBumber), from: new PhoneNumber("+19036086543"),
                body: "Kan Grubunuz İle Uyuşan İlan Var");
        }
    }
}