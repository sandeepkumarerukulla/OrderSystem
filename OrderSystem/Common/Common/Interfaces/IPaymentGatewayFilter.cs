
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IPaymentGatewayFilter
    {
        Task<string> Filter();
    }
}
