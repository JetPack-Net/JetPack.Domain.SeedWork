using JetPack.Domain.SeedWork.Exceptions;

namespace JetPack.Domain.SeedWork.Validations;

public class ExceptionValidationHandler : ValidationHandler
{
    public override void HandleError(ValidationError error) => throw new EntityValidationException(error.Message);
}