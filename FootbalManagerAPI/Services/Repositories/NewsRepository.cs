using FCPrut.Data;
using FCPrut.Models.EntityModels;
using FCPrut.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FCPrut.Services.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly PrutContext _context;

        public NewsRepository(PrutContext context)
        {
            _context = context;
        }
    
        public async Task<IEnumerable<News>> GetAllNewsAsync()
        {
            return await _context
                .News.ToListAsync();
        }

        public async Task<IEnumerable<News>> GetAmountOfLatestNewsAsync(int amount)
        {
            int countOfNews = _context.News.Count();
            return await _context
                .News
                .OrderBy(x => x.CreatedAt)
                .Reverse()
                .Take(amount)
                .ToListAsync();
        }
    }
}
