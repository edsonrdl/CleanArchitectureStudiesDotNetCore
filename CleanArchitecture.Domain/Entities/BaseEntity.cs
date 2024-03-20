namespace CleanArchitecture.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset  DateCreate{ get; set; }
    public DateTimeOffset? DateUpdate{ get; set; }
    public DateTimeOffset? DateDelete { get; set; }

}