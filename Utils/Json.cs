using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Postbox_bot.Utils
{
    public class Json
    {
        public static async Task<T> Parse<T>(string json) {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static async Task<string> Serialize(object jsonObj) {
            return JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
        }
    }
}