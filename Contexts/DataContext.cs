using Crito.Models.Entities;
using Microsoft.EntityFrameworkCore;
using static Umbraco.Cms.Core.Constants;

namespace Crito.Contexts
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public required DbSet<ContactEntity> ContactRequests { get; set; }
        public required DbSet<NewsLetterEntity> NewsLetterRequests { get; set; }

    }
}
