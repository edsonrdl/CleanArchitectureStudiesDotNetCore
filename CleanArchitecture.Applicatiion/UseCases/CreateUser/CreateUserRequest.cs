using MediatR;

namespace CleanArchitecture.Applicatiion.UseCases.CreateUser;

public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;