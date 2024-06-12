using AssetManagement.Domain.Entities;

namespace AssetManagement.Application.IRepositories;

public interface IUserRepository : IGenericRepository<User>
{
    Task<bool> LoginAsync(User user);
}
