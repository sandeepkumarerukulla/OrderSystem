
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IPaymentGatewayService
    {
        Task<string> Process(string type);
    }
}
