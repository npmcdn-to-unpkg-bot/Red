using System.Threading.Tasks;

namespace Common.HttpClient
{
    public interface IGetAsync<T>
    {
        Task<T> Execute(string uri);
    }
}
