using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interfaces.Repositories.UseCases;

public interface IUserRepository:IBaseRepository<User>
{
    Task<User> GetByEmail(string email,CancellationToken cancellationTokem);
}