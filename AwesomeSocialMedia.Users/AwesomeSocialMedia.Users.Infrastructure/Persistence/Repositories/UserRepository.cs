using AwesomeSocialMedia.Users.Core.Entities;
using AwesomeSocialMedia.Users.Core.Repositories;

namespace AwesomeSocialMedia.Users.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;
        public UserRepository(UserDbContext context)
        {
            _context = context;   
        }

        public Task AddAsync(User user)
        {
            _context.Users.Add(user);
            
            return Task.CompletedTask;
        }

        public Task<User> GetByIdAsync(Guid id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            return Task.FromResult(user);
        }

        public Task UpdateAsync(User user)
        {
            return Task.CompletedTask;
        }
    }
}
