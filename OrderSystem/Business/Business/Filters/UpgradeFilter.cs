using System.Threading.Tasks;
using Business.Makers;
using Common.Interfaces;

namespace Business.Filters
{
    public class UpgradeFilter:IPaymentGatewayFilter
    {
        public async Task<string> Filter()
        {
            return $"{await UpgradeMaker.Process()} {await EmailMaker.Process()}";
        }
    }
}
