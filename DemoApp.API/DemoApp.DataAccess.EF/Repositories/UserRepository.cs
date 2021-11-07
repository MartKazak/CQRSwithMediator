using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.Domain.Entities;
using DemoApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.DataAccess.EF.Repositories
{
    public sealed class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public Task<List<User>> GetAsync(CancellationToken cancellationToken = default) =>
            _dbContext.Users.ToListAsync(cancellationToken);

        public Task<User> GetByIdAsync(int userId, CancellationToken cancellationToken = default) =>
            _dbContext.Users.FirstOrDefaultAsync(user => user.Id == userId, cancellationToken);

        public void Insert(User user) => 
            _dbContext.Users.Add(user);
    }
}
