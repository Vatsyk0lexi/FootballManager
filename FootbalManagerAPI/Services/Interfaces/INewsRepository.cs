using FootbalManagerAPI.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Services.Interfaces
{
    public interface INewsRepository
    {
        Task<IEnumerable<News>> GetAllNewsAsync();
        Task<IEnumerable<News>> GetAmountOfLatestNewsAsync(int amount);
    }
}
