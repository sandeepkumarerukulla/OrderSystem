using System.Threading.Tasks;

namespace Business.Makers
{
    public static class CommisionMaker
    {
        public static async Task<string> Process()
        {
            return "Commission payment to the agent is generated.";
        }
    }
}
