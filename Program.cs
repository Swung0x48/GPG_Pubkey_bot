using System.Threading.Tasks;
using GPG_Pubkey_bot.Misc;

namespace GPG_Pubkey_bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Vars.Uptime.Start();
            
            string APIKey = "1092977013:AAG_wU89sLH0dz4QbG3BuNxBwVUPl6yI0gg";
            await Bot.Init(APIKey);
            
        }
    }
}
