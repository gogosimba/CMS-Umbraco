using Crito.Models.Entities;

namespace Crito.Services
{
    public class NewsLetterService
    {
        private readonly DataContext _context;

        public NewsLetterService(DataContext context)
        {
            _context = context;
        }

        public async Task<NewsLetterEntity> Create(NewsLetterEntity newsLetterEntity)
        {
            _context.NewsLetterRequests.Add(newsLetterEntity);
            await _context.SaveChangesAsync();
            return newsLetterEntity;
        }
    }
}
