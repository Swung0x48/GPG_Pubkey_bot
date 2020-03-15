using System;
using System.Threading;
using System.Threading.Tasks;
using ChannelPosting_bot.Misc;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace ChannelPosting_bot
{
    public class Bot
    {
        public static async Task Init(string APIKey)
        {
            Vars.BotClient = new TelegramBotClient(APIKey);                               // Get the API Key to start bot.
            
            var botInstance = Vars.BotClient.GetMeAsync().Result;                    // Get the bot instance info.
            Console.WriteLine($"ID: {botInstance.Id} \nName: {botInstance.FirstName}.");  // Print it.
            
            Vars.BotClient.OnMessage += OnMessage;                                        // Add OnMessage() to bot Client's OnMessage listener
            Vars.BotClient.StartReceiving();

            while (true)                                                                    
            {
                Thread.Sleep(int.MaxValue);                                // Keeping the whole thing running.
            }

        }
        
        static async void OnMessage(object sender, MessageEventArgs e) 
        {
            if (e.Message.Text != null)
            {
                
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");
                if (e.Message.Text == "/uptime")
                {
                    Vars.BotClient.SendTextMessageAsync(
                        e.Message.Chat, 
                        $"Current uptime is {Vars.Uptime}"
                        );
                }
                else if (e.Message.Text == "/start")
                {
                    Vars.BotClient.SendTextMessageAsync(
                        e.Message.Chat, " "
                        );
                }
            }
        }
    }
}