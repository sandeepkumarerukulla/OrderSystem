using System.Threading.Tasks;
using Business.Makers;
using Common.Interfaces;

namespace Business.Filters
{
    public class BookFilter: IPaymentGatewayFilter
    {
        public async Task<string> Filter()
        {
            return $"{await RoyaltyMaker.Process()} {await CommisionMaker.Process()}";
        }
    }
}
