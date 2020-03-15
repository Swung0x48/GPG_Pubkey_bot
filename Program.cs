using System;
using System.IO;
using System.Threading.Tasks;
using ChannelPosting_bot.Misc;
using ChannelPosting_bot.Utils;

namespace ChannelPosting_bot
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            Vars.Stopwatch.Start();
            //CmdProcessor.CmdPreprocess(@"/hi@bot233");

            if (!File.Exists(Vars.ConfFile))
            {
                Console.WriteLine(Language.Msg_ConfNotFound);
                Console.WriteLine(Language.Msg_FirstBoot);
                Console.WriteLine(Language.Msg_ReqApiKey);
                Vars.CurrentConf.ApiKey = Console.ReadLine();
                await IO.File.WriteConf(Vars.ConfFile, Vars.CurrentConf);
            }
            Console.WriteLine(Language.Msg_ReadConf);
            Vars.CurrentConf = await IO.File.ReadConf<ConfObj>(Vars.ConfFile);
            
            
            await IO.File.WriteConf(Vars.ConfFile, Vars.CurrentConf);
            
            Console.WriteLine(Language.Msg_BotInit);
            await Bot.Init(Vars.CurrentConf.ApiKey);
        }
    }
}
