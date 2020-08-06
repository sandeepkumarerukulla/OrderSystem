using System.Threading.Tasks;
using Business.Makers;
using Common.Interfaces;

namespace Business.Filters
{
    public class MemberShipFilter: IPaymentGatewayFilter
    {
        public async Task<string> Filter()
        {
            return $"{await MembershipMaker.Process()} {await EmailMaker.Process()}";
        }
    }
}
