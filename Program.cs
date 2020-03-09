using System;
using System.IO;
using System.Threading.Tasks;
using GPG_Pubkey_bot.Misc;
using GPG_Pubkey_bot.Utils;

namespace GPG_Pubkey_bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Vars.Stopwatch.Start();
            Vars.CurrentConf = await IO.File.ReadConf<ConfObj>(Vars.ConfFile);
            
            await IO.File.WriteConf(Vars.ConfFile, Vars.CurrentConf);
            await Bot.Init(Vars.CurrentConf.ApiKey);
        }
    }
}
