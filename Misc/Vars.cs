using System.IO;
using System.Net.Http;
using System.Reflection;
using Telegram.Bot;

namespace GPG_Pubkey_bot.Misc
{
    public class Vars {
        public readonly static string AppExecutable = Assembly.GetExecutingAssembly().Location;
        public readonly static string AppDirectory = (new FileInfo(AppExecutable)).DirectoryName;
        public static string ConfFile = Path.Combine(AppDirectory, "GPGPub_bot.json");
        public static string LangFile = Path.Combine(AppDirectory, "GPGPub_bot_locale.json");
        public static ITelegramBotClient BotClient;
        public static readonly HttpClient HttpClient = new HttpClient();
        public static ConfObj CurrentConf;
    }
}