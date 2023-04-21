using FootbalManagerAPI.Models.Entity;
using FootbalManagerAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootbalManagerAPI.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        public NewsService(INewsRepository _newsRepository)
        {
            this._newsRepository = _newsRepository;
        }
    
        public async Task<IEnumerable<News>> GetAllNewsAsync()
        {
            return await _newsRepository.GetAllNewsAsync();
        }

        public async Task<IEnumerable<News>> GetAmountOfLatestNewsAsync(int amount)
        {
            return await _newsRepository.GetAmountOfLatestNewsAsync(amount);
        }
    }
}
