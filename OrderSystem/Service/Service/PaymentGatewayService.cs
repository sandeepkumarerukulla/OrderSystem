
using System.Threading.Tasks;
using Common.Interfaces;

namespace Service
{
    public class PaymentGatewayService: IPaymentGatewayService
    {

        private readonly IPaymentGatewayFactory paymentGatewayFactory;

        public PaymentGatewayService(IPaymentGatewayFactory paymentGatewayFactory)
        {
            this.paymentGatewayFactory = paymentGatewayFactory;
        }

        public async Task<string> Process(string type)
        {
            return await this.paymentGatewayFactory.GetFilter(type).Filter();
        }
    }
}
