using Crito.Models.Entities;

namespace Crito.Services
{
    public class ContactRequestService
    {
        private readonly DataContext _context;

        public ContactRequestService(DataContext context)
        {
            _context = context;
        }

        public async Task<ContactEntity> Create(ContactEntity contactEntity)
        {
            _context.ContactRequests.Add(contactEntity);
            await _context.SaveChangesAsync();
            return contactEntity;
        }
    }
}
