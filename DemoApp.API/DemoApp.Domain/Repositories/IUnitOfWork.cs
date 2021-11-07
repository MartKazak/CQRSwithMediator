using System.Threading;
using System.Threading.Tasks;

namespace DemoApp.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
