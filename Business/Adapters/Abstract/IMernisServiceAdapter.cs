using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Adapters.Abstract
{
    public interface IMernisServiceAdapter
    {
        Task<bool> VerifyCid(User user);
    }
}