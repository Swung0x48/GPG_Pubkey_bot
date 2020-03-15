using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChannelPosting_bot.Utils
{
    public class CmdProcessor
    {
        public static async Task<bool> CmdPreprocess(string input)
        {
            string atPattern = @"@\S*";
            string standardized = "";
            
            Regex rgx = new Regex(atPattern);
            Console.WriteLine(rgx.Replace(input, standardized));
            return true;
        }
    }
}