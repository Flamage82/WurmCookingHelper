using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace WurmCookingHelper.Data
{
    public class Repository : IRepository
    {
        public async Task<T> Read<T>()
        {
            var file = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Affinities.json"));
            await using var stream = file.OpenRead();
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
