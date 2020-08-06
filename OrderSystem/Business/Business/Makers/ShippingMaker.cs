using System.Threading.Tasks;

namespace Business.Makers
{
    public static class ShippingMaker
    {
        public static async Task<string> Process()
        {
            return "Generated the packing slip for shipping.";
        }
    }
}
