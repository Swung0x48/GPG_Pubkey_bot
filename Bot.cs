using System;
using System.Threading;
using System.Threading.Tasks;
using GPG_Pubkey_bot.Misc;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace GPG_Pubkey_bot
{
    public class Bot
    {
        public static async Task Init(string APIKey)
        {
            Vars.BotClient = new TelegramBotClient(APIKey);
            
            var botInstance = Vars.BotClient.GetMeAsync().Result;
            Console.WriteLine($"ID: {botInstance.Id} \nName: {botInstance.FirstName}.");
            
            Vars.BotClient.OnMessage += OnMessage;
            Vars.BotClient.StartReceiving();

            while (true)
            {
                Thread.Sleep(int.MaxValue);
            }

        }
        
        static async void OnMessage(object sender, MessageEventArgs e) 
        {
            if (e.Message.Text != null)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");

                await Vars.BotClient.SendTextMessageAsync(e.Message.Chat, e.Message.Text);
            }
        }
    }
}