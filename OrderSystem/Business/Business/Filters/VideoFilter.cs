using Business.Makers;
using Common.Interfaces;
using System.Threading.Tasks;

namespace Business.Filters
{
    public class VideoFilter: IPaymentGatewayFilter
    {
        public async Task<string> Filter()
        {
            return await VideoMaker.Process();
        }
    }
}
