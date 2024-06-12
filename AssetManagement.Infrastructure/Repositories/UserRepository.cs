using AssetManagement.Application.IRepositories;
using AssetManagement.Domain.Entities;
using AssetManagement.Infrastructure.Migrations;
using AutoMapper;

namespace AssetManagement.Infrastructure.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AssetManagementDBContext context, IMapper mapper) : base(context, mapper)
    {
    }


    public Task<bool> LoginAsync(User user)
    {
        throw new NotImplementedException();
    }

}
