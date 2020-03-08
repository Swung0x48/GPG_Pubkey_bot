using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GPG_Pubkey_bot.Utils;

namespace GPG_Pubkey_bot.IO
{
    public class File
    {
        public async Task<int> WriteConf(string filename, object confObj)
        {
            await System.IO.File.WriteAllTextAsync(
                filename, 
                await Json.Serialize(confObj)
            );
            return 0;
        }

        public async Task<object> ReadConf(string filename)
        {
            return await Json.Parse<object>(
                await System.IO.File.ReadAllTextAsync(
                    filename, 
                    Encoding.UTF8
                    )
                );
        }
    }
}