using System.Collections.Generic;
using System.Threading.Tasks;
using WurmCookingHelper.Data;
using WurmCookingHelper.Data.Models;

namespace WurmCookingHelper.ConsoleApplication
{
    public class Application
    {
        private readonly IRepository repository;

        public Application(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Run()
        {
            var test = await repository.Read<List<Affinity>>();
        }
    }
}
