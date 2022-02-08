using Business.Adapters.Abstract;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Business.Adapters.Concrete
{
    public class SmsService : ISmsService
    {
        private const string accountSid = "AC99fa5e45d78df1fd80f6b7b9f22e2811";
        private const string authToken = "c39c0be468ce322668014bdb49921c32";
        public void SendSms(string PhoneNumber)
        {
            TwilioClient.Init(accountSid,authToken);
            var message = MessageResource.Create(to:new Twilio.Types.PhoneNumber(PhoneNumber), from: new Twilio.Types.PhoneNumber("+19036086543"),body:"Kan Grubunuz İle Uyuşan İlanlar Var" );
            
        }
    }
}
