
namespace Common.Interfaces
{
    public interface IPaymentGatewayFactory
    {
        IPaymentGatewayFilter GetFilter(string type);
    }
}
