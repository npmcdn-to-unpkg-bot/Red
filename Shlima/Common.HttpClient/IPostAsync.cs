using System.Threading.Tasks;

namespace Common.HttpClient
{
    public interface IPostAsync<T>
    {
        Task<T> Execute(string uri);
    }
}
