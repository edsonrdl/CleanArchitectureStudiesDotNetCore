using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.Repositories;
using CleanArchitecture.Domain.Interfaces.Repositories.UseCases;
using CleanArchitecture.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {

    }
    public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
        var user = await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        if (user == null)
        {
            return null;
        }

        return user;
    }
}
