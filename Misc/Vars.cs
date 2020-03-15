using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using Telegram.Bot;

namespace Postbox_bot.Misc
{
    public class Vars {
        public static Stopwatch Stopwatch = new Stopwatch();
        public readonly static string AppExecutable = 
            Assembly.GetExecutingAssembly().Location;
        public readonly static string AppDirectory = 
            (new FileInfo(AppExecutable)).DirectoryName;
        public static string ConfFile = 
            Path.Combine(AppDirectory, "Postbox_bot.json");
        public static string LangFile = 
            Path.Combine(AppDirectory, "Postbox_bot_locale.json");
        public static ITelegramBotClient BotClient;
        public static readonly HttpClient HttpClient = new HttpClient();
        public static ConfObj CurrentConf = new ConfObj();

        public static string Uptime
        {
            get => Stopwatch.Elapsed.ToString();
        }
    }
}