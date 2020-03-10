using System.Net.Http;
using System.Threading.Tasks;
using ChannelPosting_bot.Misc;

namespace ChannelPosting_bot.IO
{
    public class Networking
    {
        public static async Task<string> MakeHttpRequestAsync(string url)
        {
            try	{
                string responseBody = await Vars.HttpClient.GetStringAsync(url);
                return responseBody;
            }  
            catch(HttpRequestException e) {
                return $"Error :{e.Message} ";
            }
        }
    }
}