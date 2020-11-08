using System.Threading.Tasks;

namespace WurmCookingHelper.Data
{
    public interface IRepository
    {
        Task<T> Read<T>();
    }
}
