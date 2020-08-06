
using Business.Filters;
using Common.Interfaces;

namespace Business
{
    public class PaymentGatewayFactory: IPaymentGatewayFactory
    {
        public IPaymentGatewayFilter GetFilter(string type)
        {
            switch (type)
            {
                case "physical product":
                    return new ProductFilter();

                case "book":
                    return new BookFilter();

                case "membership":
                    return new MemberShipFilter();

                case "upgrade":
                    return new UpgradeFilter();

                case "learning to ski video":
                    return new VideoFilter();

                default:
                    return null;
            }
        }
    }
}
