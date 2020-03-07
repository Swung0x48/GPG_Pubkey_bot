using System;
using System.Threading.Tasks;
using GPG_Pubkey_bot.Misc;
using Newtonsoft.Json;
using Telegram.Bot;


namespace GPG_Pubkey_bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string APIKey = "1092977013:AAG_wU89sLH0dz4QbG3BuNxBwVUPl6yI0gg";
            Vars.BotClient = new TelegramBotClient(APIKey);
            
            var bot = Vars.BotClient.GetMeAsync().Result;
            Console.WriteLine(
                $"ID: {bot.Id} \nName: {bot.FirstName}."
            );
        }
    }
}
