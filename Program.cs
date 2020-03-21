using System;
using System.IO;
using System.Threading.Tasks;
using Postbox_bot.Utils;
using Postbox_bot.Misc;

namespace Postbox_bot
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            Vars.Stopwatch.Start();
            //CmdProcessor.CmdPreprocess(@"/hi@bot233");

            if (!File.Exists(Vars.ConfFile))
            {
                Console.WriteLine(Language.MsgConfNotFound);
                Console.WriteLine(Language.MsgFirstBoot);
                Console.WriteLine(Language.MsgReqApiKey);
                Vars.CurrentConf.ApiKey = Console.ReadLine();
                await IO.File.WriteConf(Vars.ConfFile, Vars.CurrentConf);
            }
            Console.WriteLine(Language.MsgReadConf);
            Vars.CurrentConf = await IO.File.ReadConf<ConfObj>(Vars.ConfFile);
            
            
            await IO.File.WriteConf(Vars.ConfFile, Vars.CurrentConf);
            
            Console.WriteLine(Language.MsgBotInit);
            await Bot.Init(Vars.CurrentConf.ApiKey);
        }
    }
}
