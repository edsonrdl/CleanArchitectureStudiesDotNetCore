﻿using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interfaces;

public interface IBaseRepository<T> where T:BaseEntity
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> Get(Guid id,CancellationToken cancellation);
    Task<List<T>> GetAll(Guid id, CancellationToken cancellation);
}