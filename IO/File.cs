using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GPG_Pubkey_bot.Utils;

namespace GPG_Pubkey_bot.IO
{
    public class File
    {
        public async Task<int> WriteConf(string Filename, object ConfObj)
        {
            await System.IO.File.WriteAllTextAsync(
                Filename, 
                await Json.Serialize(ConfObj)
            );
            return 0;
        }

        public async Task<object> ReadConf(string Filename)
        {
            string content = await System.IO.File.ReadAllTextAsync(
                Filename,
                Encoding.UTF8
            );
            return await Json.Parse<object>(content);
        }
    }
}