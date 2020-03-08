using System.Net.Http;
using System.Threading.Tasks;
using GPG_Pubkey_bot.Misc;

namespace GPG_Pubkey_bot.IO
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