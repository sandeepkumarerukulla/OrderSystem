using System.Threading.Tasks;
using Business.Makers;
using Common.Interfaces;

namespace Business.Filters
{
    public class ProductFilter: IPaymentGatewayFilter
    {
        public async Task<string> Filter()
        {
            return $"{await ShippingMaker.Process()} {await CommisionMaker.Process()}";
        }

    }
}
