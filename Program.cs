using System;
using System.IO;
using System.Threading.Tasks;
using ChannelPosting_bot.Misc;

namespace ChannelPosting_bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Vars.Stopwatch.Start();

            if (!File.Exists(Vars.ConfFile))
            {
                Console.WriteLine("Configuration file not found. A new one will be created.");
                Console.WriteLine("It seems this is the first time you launch this. A setup will be followed by...");
                Console.WriteLine("Please enter your Telegram bot API key:");
                Vars.CurrentConf.ApiKey = Console.ReadLine();
                await IO.File.WriteConf(Vars.ConfFile, Vars.CurrentConf);
            }
            Console.WriteLine("Reading Configuration...");
            Vars.CurrentConf = await IO.File.ReadConf<ConfObj>(Vars.ConfFile);
            
            
            await IO.File.WriteConf(Vars.ConfFile, Vars.CurrentConf);
            
            Console.WriteLine("Bot Initializing...");
            await Bot.Init(Vars.CurrentConf.ApiKey);
        }
    }
}
