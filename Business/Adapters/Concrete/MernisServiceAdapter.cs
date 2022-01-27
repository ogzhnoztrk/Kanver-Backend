using System.Threading.Tasks;
using Business.Adapters.Abstract;
using Entities.Concrete;
using wsKPSPublic;

namespace Business.Adapters.Concrete
{
    public class MernisServiceAdapter : IMernisServiceAdapter
    {
        public async Task<bool> VerifyCid(User user)
        {
            return await Verify(user);
        }

        public static async Task<bool> Verify(User user)
        {
            {
                using (var svc = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
                {
                    var cmd = await svc.TCKimlikNoDogrulaAsync(
                        long.Parse(user.IdentityNumber), user.Name.ToUpper(), user.LastName.ToUpper(),
                        user.BirthDay.Year
                    );

                    return cmd.Body.TCKimlikNoDogrulaResult;
                }
            }
        }
    }
}