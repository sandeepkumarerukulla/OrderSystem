using System.Threading.Tasks;

namespace Business.Makers
{
    public static class EmailMaker
    {
        public static async Task<string> Process()
        {
            return "Email sent to owner about activation/upgrade.";
        }
    }
}
