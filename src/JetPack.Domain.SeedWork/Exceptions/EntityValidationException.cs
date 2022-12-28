using JetPack.Domain.SeedWork.Validations;

namespace JetPack.Domain.SeedWork.Exceptions;

public class EntityValidationException : DomainException
{
    public IReadOnlyCollection<ValidationError>? Errors { get; }

    public EntityValidationException(
        string? message,
        IReadOnlyCollection<ValidationError>? errors = null
    ) : base(message)
        => Errors = errors;
}
